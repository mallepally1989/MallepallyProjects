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
    public partial class Loss_Of_Pay_Summary : Coromandel.Coromandel_MasterPage
    {
        DataSet dsLOPS = new DataSet();
        GeneralClass GC = new GeneralClass();
        string LocalEmpId, LocalEmpName, LocalLOPMonth;
        string locationtype;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        /// <summary>
        /// Initializes a new instance of the <see cref="Loss_Of_Pay_Summary"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Loss_Of_Pay_Summary(string EmpId, string EmpName, string LOPMonth,string locallocationtype)
        {
            InitializeComponent();
            LocalEmpId = EmpId;
            LocalEmpName = EmpName;
            lblExName.Text = EmpName;
            LocalLOPMonth = LOPMonth;
            locationtype = locallocationtype; 

          //  lblupdateddate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblupdateddate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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
                /*Query For Geting Data from Excel Sheet */
                dsLOPS = GC.ExcelConnectivity("select [ LOP Dates] from [LOP_Summary$] where [Emp No]='" + EmpId + "' and [Month]='" + LOPMonth + "'", "OleDbConnString_LossOfPay_" + "" + locationtype + "");
                if (dsLOPS.Tables[0].Rows.Count > 0)
                {

                    dataGridView1.AutoGenerateColumns = true;
                    bindingSource1.DataSource = dsLOPS.Tables[0];
                    dataGridView1.DataSource = bindingSource1;
                }
                else
                {
                    
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "No Details Available";
                
                }
            }
            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                lbl_Error.Text = "No Details Available";
            }
        }
        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }
        /// <summary>
        /// Redirecting to Loss Of Pay form with EmpId and EmpName
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Loss_Of_Pay ObjLOP = new Loss_Of_Pay(LocalEmpId, LocalEmpName, locationtype);
            ObjLOP.Show();
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
            Member_Account ObjMA = new Member_Account(LocalEmpId, LocalEmpName, locationtype);
            ObjMA.Show();
        }
        /// <summary>
        /// Redirecting to Welcome Screen form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
        }
    }
}
