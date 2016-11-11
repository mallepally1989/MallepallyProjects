using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Configuration;

namespace Coromandel
{
    
    public partial class LIC_Policies : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        DataSet dsLIC = new DataSet();
        
        GeneralClass GC = new GeneralClass();
        
        string localEmpId;
        string locationType;
        string localEmpName;
        /// <summary>
        /// Initializes a new instance of the <see cref="LIC_Policies"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public LIC_Policies(string EmpId, string EmpName, string locallocationType)
        {
            InitializeComponent();
            localEmpId = EmpId;
            localEmpName = EmpName;
            lblExName.Text = EmpName;
            locationType = locallocationType;
          //  lblDt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblDt.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];

            try
            {

                _am.WarningMinutes = Convert.ToDouble(ConfigurationManager.AppSettings["WarningMinutes"]);
                _am.MaxMinutesIdle = Convert.ToDouble(ConfigurationManager.AppSettings["MaxMinutesIdle"]);
                _am.Idle += new EventHandler(am_Idle);
                activityMonitorBindingSource.DataSource = _am;
            }
            catch
            {
                MessageBox.Show("Entered into wrong data");
            }

            try
            {
                //Query for Geting Data form Excel sheet
                dsLIC = GC.ExcelConnectivity("select * from [Sheet1$] where [Emp No] = " + EmpId + "", "OleDbConnString_LIC_Policies");
                if(dsLIC.Tables[0].Rows.Count > 0)
                {

                dgvLIC.AutoGenerateColumns = true;
                bindingSource1.DataSource = dsLIC.Tables[0];
                dgvLIC.DataSource=bindingSource1;              
                }

                else
                {
               
                    lblError.Visible = true;
                    lblError.Text = "No Details Available";

                }
            }

            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                this.Close();
                Employee_Lgn ObjEL = new Employee_Lgn(locationType);
                ObjEL.Show();
                lblError.Visible = true;
                lblError.Text = "No Details Available";
            }

        }
        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }
        /// <summary>
        /// Redirecting to Member Account form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account ObjMA = new Member_Account(localEmpId, localEmpName, locationType);
            ObjMA.Show();
        }
        /// <summary>
        /// Redirecting to Member Account form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account ObjMA = new Member_Account(localEmpId, localEmpName, locationType);
            ObjMA.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnLogout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWs = new Welcome_Screen();
            ObjWs.Show();
        }
    }
}
