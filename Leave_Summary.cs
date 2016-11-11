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

    
    public partial class Leave_Summary : Coromandel.Coromandel_MasterPage
    {

        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        DataSet dsTotalLeaves = new DataSet();

       
        GeneralClass GC = new GeneralClass();

        
        string localEmpId, localEmpName,locationtype;

      
        string localLeaveDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="Leave_Summary"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="ViewDetails">The view details.</param>
        /// <remarks></remarks>
        public Leave_Summary(string EmpId, string EmpName, string ViewDetails, string locallocationType)
        {
            InitializeComponent();
            localEmpId = EmpId;
            lblExName.Text = EmpName;
            localEmpName = EmpName;
            localLeaveDetails = ViewDetails;
            locationtype = locallocationType;
           // lblUpdatedDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblUpdatedDate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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
           
            try
            {
                dsTotalLeaves = GC.ExcelConnectivity("select * from [Sheet1$] where [Emp No]=" + EmpId + " and [Leave Type]='" + ViewDetails + "'", "OleDbConnString_LeaveRecords_" + "" + locationtype + "");
                    
                    if (dsTotalLeaves.Tables[0].Rows.Count > 0)
                    {
                        dGVLeaveSummary.AutoGenerateColumns = true;
                        bindingSource1.DataSource = dsTotalLeaves.Tables[0];
                        dGVLeaveSummary.DataSource = bindingSource1;
                       LblLeaveType.Visible = true;
                       LblLeaveType.Text = ViewDetails ;
                    }
                    else
                    {
                        pnlLeaveSummary.Visible = false;
                        lblLeaveREC.Visible = true;
                        lblLeaveREC.Text = "No Details Available";
                    }
            }
            catch(Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                pnlLeaveSummary.Visible = false;
                lblLeaveREC.Visible = true;
                lblLeaveREC.Text = "No Details Available";
            }
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
            Member_Account ObjMC = new Member_Account(localEmpId, localEmpName, locationtype);
            ObjMC.Show();
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
            Leave_Record ObjLR = new Leave_Record(localEmpId, localEmpName,locationtype);
            ObjLR.Show();
        }


        /// <summary>
        /// Handles the Load event of the Leave_Summary control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void Leave_Summary_Load(object sender, EventArgs e)
        {

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
