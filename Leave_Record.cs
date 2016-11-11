using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Coromandel
{
    
    public partial class Leave_Record : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
       
        string LocalEmpId, LocalEmpName;
        /// <summary>
        /// initialising dataset
        /// </summary>
        DataSet dsleaverecords = new DataSet();
        /// <summary>
        /// declaring the general class
        /// </summary>
        GeneralClass GC = new GeneralClass();

        
        string localSickLeaves = "Sick Leave";

       
        string localEarnedLeaves = "Earned Leave";

        
        string localCasualLeaves = "Casual Leave";
        string locationtype;

        /// <summary>
        /// Initializes a new instance of the Leave_Record class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Leave_Record(string EmpId, string EmpName, string locallocationtype)
        {
            InitializeComponent();
            LocalEmpId = EmpId;
            LocalEmpName = EmpName;
            lblExName.Text = EmpName;
            locationtype = locallocationtype;
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

           // lblUpdatedDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblUpdatedDate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
            //try
            //{
            //    /*query for getting data from excel sheet */
            //    dsleaverecords = GC.ExcelConnectivity("select * from [LeaveDetails$] where [Emp No]='" + EmpId + "' ", "OleDbConnString_LeaveRecords_" + "" + locationtype + "");
            //    // condititonal check for tables
            //    if (dsleaverecords.Tables[0].Rows.Count > 0)
            //    {
            //        dGVLeaveRecords.AutoGenerateColumns = true;
            //        bindingSource1.DataSource = dsleaverecords.Tables[0]; // binding data from tables
            //        dGVLeaveRecords.DataSource = bindingSource1;// binding data to the gridview
            //    }
            //    else 
            //    {
            //        pnlLeaveRecords.Hide();
            //        lblError.Visible = true;
            //        lblError.Text = "No Details Available";
            //        btnCasualLeave.Visible = false;
            //        btnEarnedLeave.Visible = false;
            //        btnSickLeaves.Visible = false;
            //    }
            // }

         
            //catch (Exception ex)
            //{
            //    GC.ErrorLoging(ex.ToString());
            //    this.Close();
            //    Employee_Lgn ObjEL = new Employee_Lgn(locationtype);
            //    ObjEL.Show();
            //    lblError.Visible = true;
            //    lblError.Text = "No Details Available";
            //    btnCasualLeave.Visible = false;
            //    btnEarnedLeave.Visible = false;
            //    btnSickLeaves.Visible = false;
            //}
        }

        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Handles the Click event of the btnHome control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account OblMC = new Member_Account(LocalEmpId, LocalEmpName,locationtype);
            OblMC.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave_Detail ObjLD = new Leave_Detail(LocalEmpId, LocalEmpName,locationtype);
            ObjLD.Show();
        }

        /// <summary>
        /// redirects to the casual leaves details of the employee in leave summary form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnCasualLeave_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave_Summary ObjLS = new Leave_Summary(LocalEmpId, LocalEmpName, localCasualLeaves, locationtype);
            ObjLS.Show();
        }

        /// <summary>
        /// redirects to the earned leaves details  of the employee in leave summary form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnEarnedLeave_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave_Summary ObjLS = new Leave_Summary(LocalEmpId, LocalEmpName, localEarnedLeaves, locationtype);
            ObjLS.Show();
        }

        /// <summary>
        /// rediredts to the sick leave details of the employee in leave summary form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSickLeaves_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave_Summary ObjLS = new Leave_Summary(LocalEmpId, LocalEmpName, localSickLeaves, locationtype);
            ObjLS.Show();
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
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show();
        }
    }
}
        
   