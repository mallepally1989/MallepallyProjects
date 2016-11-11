using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Coromandel
{
    public partial class Member_Account : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        DataSet dsEmpName = new DataSet();
       
        GeneralClass GC = new GeneralClass();
        
        string localEmpId,localEmpName;
        string locationType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Member_Account"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Member_Account(string EmpId, string EmpName, string locallocationType)
        {
            InitializeComponent();
            locationType = locallocationType;
            localEmpName = EmpName;
            lblExName.Text = localEmpName +" " +"ACCOUNT";

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
            localEmpId = EmpId;
            localEmpName = EmpName;
          //  lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblDate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];


            //try
            //{
            //    //query to connect the excel sheets and get the data
            //    dsEmpName = GC.ExcelConnectivity("Select [Employee Name] from [User$] where [Emp No]='" + EmpId + "'", "OleDbConnString_UserLogin'"+locationType+"'");

            //    if (dsEmpName.Tables[0].Rows.Count > 0) 

            //    {

            //        lblExName.Text = dsEmpName.Tables[0].Rows[0]["Employee Name"].ToString() + "  " + "ACCOUNT";
            //        localEmpName = dsEmpName.Tables[0].Rows[0]["Employee Name"].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    GC.ErrorLoging(ex.ToString());
            //    this.Close();
            //    Employee_Lgn ObjEL = new Employee_Lgn(locationType);
            //    ObjEL.Show();
            //    //MessageBox.Show("Please Relogin");
            //}
        }
        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }
        

        /// <summary>
        /// Handles the Click event of the btnlevDetails control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnlevDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave_Detail ObjLD = new Leave_Detail(localEmpId, localEmpName, locationType);
            ObjLD.Show();
        }

        /// <summary>
        /// Handles the 1 event of the btnPaySlips_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPaySlips_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Pay_Slip1 ObjPS = new Pay_Slip1(localEmpId, localEmpName, locationType);
            ObjPS.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnME control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnME_Click(object sender, EventArgs e)
        {
            this.Close();
            Medical_Expences ObjME = new Medical_Expences(localEmpId, localEmpName, locationType);
            ObjME.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnLoneDetails control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLoneDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            LoanTypes objLT = new LoanTypes(localEmpId, localEmpName, locationType);
            objLT.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnOT control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnOT_Click(object sender, EventArgs e)
        {
            this.Close();
            Over_Time ObjOT = new Over_Time(localEmpId, localEmpName, locationType);
            ObjOT.Show();
        }

        /// <summary>
        /// Handles the 1 event of the btnLIC_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLIC_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LIC_Policies ObjLIC = new LIC_Policies(localEmpId, localEmpName, locationType);
            ObjLIC.Show();
        }

        private void btnChgpwd_Click(object sender, EventArgs e)
        {
            this.Close();
            Change_password ObjCP = new Change_password(localEmpId, localEmpName, locationType);
            ObjCP.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
        }

       

        

        
    }
}
