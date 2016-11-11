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
    
    public partial class Total_Leaves_Per_Month : Coromandel.Coromandel_MasterPage
    {
        
        DataSet dsTotalLeaves = new DataSet();
        GeneralClass GC = new GeneralClass();
       
        string localEmpId,localEmpName;
        string locationtype;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
      
        /// <summary>
        /// Initializes a new instance of the <see cref="Total_Leaves_Per_Month"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
       public Total_Leaves_Per_Month(string EmpId,string EmpName,string locallocationtype)
        {
            InitializeComponent();
            localEmpId = EmpId;
            lblExName.Text = EmpName;
            localEmpName = EmpName;
            locationtype = locallocationtype;
          // lbl_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
           lbl_Date.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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
                /*emp details sheet connection */
                dsTotalLeaves = GC.ExcelConnectivity("Select * from [Sheet1$] where [Emp No]=" + EmpId + "", "OleDbConnString_TotalLeaves_" + "" + locationtype + "");

                if (dsTotalLeaves.Tables[0].Rows.Count > 0)
                {
                    /* binding data from empdetails to get user name*/
                    GrdvwTotalLeaveRecords.AutoGenerateColumns = true;
                    bindingSource1.DataSource = dsTotalLeaves.Tables[0];
                    GrdvwTotalLeaveRecords.DataSource = bindingSource1;
                }
                else
                {
                    pnlTotalLeave.Visible = false;
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "No Details Available";
                }
            }
            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                lbl_Error.Visible = true;
                lbl_Error.Text = "No Details Available";
            }
        }
       void am_Idle(object sender, EventArgs e)
       {
           Application.Restart();
       }
        /// <summary>
        /// Handles the Click event of the btn_Home control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account ObjMC = new Member_Account(localEmpId, localEmpName, locationtype);
            ObjMC.Show();
        }

        /// <summary>
        /// Handles the Click event of the btn_Back control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            //DataSet dsTP = new DataSet();
            Leave_Detail ObjLD = new Leave_Detail(localEmpId, localEmpName, locationtype);
            ObjLD.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
        }

     
    }
}
