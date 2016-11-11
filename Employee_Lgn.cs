using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
//using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Coromandel
{
   
	public partial class Employee_Lgn : Coromandel.Coromandel_MasterPage
	{
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        DataSet dslogin = new DataSet();
        GeneralClass GC = new GeneralClass();

        string locationType;
        public Employee_Lgn(string locallocationType)
		{
			InitializeComponent();

            locationType = locallocationType;
            txtUserid.Focus();
            try
            {

                _am.WarningMinutes = Convert.ToDouble(ConfigurationManager.AppSettings["WarningMinutes"]);
                _am.MaxMinutesIdle = Convert.ToDouble(ConfigurationManager.AppSettings["MaxMinutesIdle"]);
                _am.Idle += new EventHandler(am_Idle);
                activityMonitorBindingSource.DataSource = _am;
            }
            catch
            {

            }
		}
        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLogin_Click(object sender, EventArgs e)
        {
             try
            {
                    if (txtUserid.Text.Trim() ==string.Empty)
                    {
                        errorProvider1.SetError(txtUserid, "Enter UserId");
                        txtUserid.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }

                    if (txtPassword.Text.Trim() == string.Empty)
                    {
                        errorProvider1.SetError(txtPassword, "Enter Password");                     
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }

                    if (txtUserid.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                    {
                        //dslogin = GC.ExcelConnectivity("Select * from [User$] where [Emp No] ='" + txtUserid.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "' ", "OleDbConnString_UserLoginVisakhapatnam");

                        dslogin = GC.ExcelConnectivity("Select * from [Sheet1$] where [Emp No] ='" + txtUserid.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "' ", "OleDbConnString_UserLogin_" + "" + locationType + "");

                        // checking the credentials of auser

                        if (dslogin.Tables[0].Rows.Count > 0)
                        {
                            this.Close();
                            Member_Account objMA = new Member_Account(dslogin.Tables[0].Rows[0]["Emp No"].ToString(), dslogin.Tables[0].Rows[0]["Employee Name"].ToString(), locationType); // redirecting to Member Account
                            objMA.Show();
                        }
                        else
                        {
                            lblerror.Text = "The UserId or Password you entered is incorrect.";
                            txtUserid.Text = "";
                            txtPassword.Text = "";
                            txtUserid.Focus();
                        }
                    }
             }

              catch(Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                lblRelogin.Text = "Please Relogin";
                txtUserid.Text = "";
                txtPassword.Text = "";
                txtUserid.Focus();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWC = new Welcome_Screen(); // redirecting to Member Account
            ObjWS.Show();
        }

        private void Employee_Lgn_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
