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
    public partial class Over_Time : Coromandel.Coromandel_MasterPage
    {
       // DataSet dsOT = new DataSet();
       // GeneralClass GC = new GeneralClass();
        string localEmpId;
        string localEmpName, locationType;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        /// <summary>
        /// Initializes a new instance of the <see cref="Over_Time"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Over_Time(string EmpId, string EmpName, string locallocationType)
        {

            
            InitializeComponent();
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

            dgvOT.Visible = false;
            locationType = locallocationType;
            localEmpId = EmpId;
            lblExName.Text = EmpName;
            localEmpName = EmpName;
            lblcomboxerror.Text = string.Empty;
          //  lblupdateddate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblupdateddate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];

            int year = DateTime.Now.Year;
            int year1 = year - 1;
            int year2 = year - 2;

            cmbSelectYear.Items.Insert(0, "--Select--");
            cmbSelectYear.Items.Insert(1,year.ToString());
            cmbSelectYear.Items.Insert(2,year1.ToString());
            cmbSelectYear.Items.Insert(3, year2.ToString());
            cmbSelectYear.SelectedIndex = 0;

            cmbSelectMonth.Items.Insert(0, "--select--");
            cmbSelectMonth.Items.Insert(1,"January");
            cmbSelectMonth.Items.Insert(2,"February");
            cmbSelectMonth.Items.Insert(3,"March");
            cmbSelectMonth.Items.Insert(4,"April");
            cmbSelectMonth.Items.Insert(5,"May");
            cmbSelectMonth.Items.Insert(6,"June");
            cmbSelectMonth.Items.Insert(7,"July");
            cmbSelectMonth.Items.Insert(8, "August");
            cmbSelectMonth.Items.Insert(9,"September");
            cmbSelectMonth.Items.Insert(10,"October");
            cmbSelectMonth.Items.Insert(11,"November");
            cmbSelectMonth.Items.Insert(12,"December");
            cmbSelectMonth.SelectedIndex = 0;
            
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
        /// Redirecting to Welcome Screen form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>

        private void SelectYearMonth()
        {
           GeneralClass GC = new GeneralClass();
            DataSet dsOT = new DataSet();
            dsOT = null;
            dgvOT.DataSource = null;
            lblErrorMsg.Text = String.Empty;

            if (cmbSelectYear.SelectedIndex == 0 && cmbSelectMonth.SelectedIndex == 0)
            {
                pnlOT.Visible = false;
                lblcomboxerror.Text = "Please Select Year And Month ";
                return;
            }
            else if (cmbSelectYear.SelectedIndex == 0)
            {
                pnlOT.Visible = false;
                lblcomboxerror.Text = "Please Select Year  ";
                return;
            }
            else if (cmbSelectMonth.SelectedIndex == 0)
            {
                pnlOT.Visible = false;
                lblcomboxerror.Text = "Please Select  Month ";
                return;
            }

            else if (cmbSelectYear.SelectedIndex != 0 && cmbSelectMonth.SelectedIndex != 0)
            {
                try
                {
                    // Query for Geting Data form Excel sheet
                    dsOT = GC.ExcelConnectivityforOT("Select * FROM [Sheet1$] where [Emp No]=" + localEmpId + "", cmbSelectMonth.SelectedIndex.ToString(), cmbSelectYear.SelectedItem.ToString(), locationType);
                    if (dsOT.Tables[0].Rows.Count > 0)
                    {
                        pnlOT.Visible = true;
                        dgvOT.AutoGenerateColumns = true;
                        bindingSource1.DataSource = dsOT.Tables[0];
                        dgvOT.DataSource = bindingSource1;
                        this.dgvOT.Columns["Emp No"].Visible = false;
                        this.dgvOT.Columns["Payroll Area"].Visible = false;
                        dgvOT.Visible = true;
                    }
                    else
                    {
                        pnlOT.Visible = false;
                        lblErrorMsg.Visible = true;
                        lblErrorMsg.Text = "No Details Available";
                    }

                }
                catch (Exception ex)
                {
                    GC.ErrorLoging(ex.ToString());
                    pnlOT.Visible = false;
                    lblErrorMsg.Visible = true;
                    lblErrorMsg.Text = "No Details Available";
                }
            }
            lblcomboxerror.Text = string.Empty;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            //dgvOT.DataSource = null;
            SelectYearMonth();
         
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
        }

       
        
    }

}
