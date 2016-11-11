using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq;
using System.IO;
using System.Configuration;


namespace Coromandel
{
    public partial class Loss_Of_Pay : Coromandel.Coromandel_MasterPage
    {
        DataSet dsLOP = new DataSet();

        string LocalEmpId, LocalEmpName, locationType;
        
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        
        
        //DataSet dsCmbDates = new DataSet();

        /// <summary>
        /// Initializes a new instance of the <see cref="Loss_Of_Pay"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Loss_Of_Pay(string EmpId, string EmpName, string locallocationType)
        {

            InitializeComponent();
            pnlLOP.Visible = false;

            locationType = locallocationType;
            LocalEmpId = EmpId;
            LocalEmpName = EmpName;
            lbl_EmpName.Text = EmpName;
          //  lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblDate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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

            int year = DateTime.Now.Year;
            int year1 = year - 1;
            int year2 = year - 2;
            cmbYear.Items.Insert(0, "--select--");
            cmbYear.Items.Insert(1, year.ToString());
            cmbYear.Items.Insert(2, year1.ToString());
            cmbYear.Items.Insert(3, year2.ToString());
            cmbYear.SelectedIndex = 0;
            // appending items (Months) to Combobox
            cmb_Selectmnth.Items.Insert(0, "--Select--");
            cmb_Selectmnth.Items.Insert(01, "January");
            cmb_Selectmnth.Items.Insert(02, "February");
            cmb_Selectmnth.Items.Insert(03, "March");
            cmb_Selectmnth.Items.Insert(04, "April");
            cmb_Selectmnth.Items.Insert(05, "May");
            cmb_Selectmnth.Items.Insert(06, "June");
            cmb_Selectmnth.Items.Insert(07, "July");
            cmb_Selectmnth.Items.Insert(08, "August");
            cmb_Selectmnth.Items.Insert(09, "September");
            cmb_Selectmnth.Items.Insert(10, "October");
            cmb_Selectmnth.Items.Insert(11, "November");
            cmb_Selectmnth.Items.Insert(12, "December");
            cmb_Selectmnth.SelectedIndex = 0;
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
            Member_Account ObjMA = new Member_Account(LocalEmpId, LocalEmpName, locationType);
            ObjMA.Show(); 
            
        }

        /// <summary>
        /// Handles the LinkClicked event of the ll_Logout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void ll_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
           
        }

        /// <summary>
        /// Handles the 1 event of the btnBack_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Leave_Detail ObjLD = new Leave_Detail(LocalEmpId, LocalEmpName, locationType);
            ObjLD.Show();
        }
        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
     
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           }
            
        private void SelectYearMonth()
        {
           
            GeneralClass GC = new GeneralClass();
            DataSet dsOT = new DataSet();
            dsOT = null;
            //dsLOP.DataSource = null;
            label2.Text = String.Empty;
           
             if (cmbYear.SelectedIndex == 0)
            {
                pnlLOP.Visible = false;
                label2.Text = "Please Select Year";
                return;
            }
             else if (cmb_Selectmnth.SelectedIndex == 0 )
             {
                 label2.Text = "Please Select Month";

             }

             else if (cmbYear.SelectedIndex != 0 && cmb_Selectmnth.SelectedIndex != 0)

                try
                {

                    //Query for Geting Data form Excel sheet

                    dsLOP = GC.ExcelConnectivityforLOP("Select * FROM [Sheet1$] where [Emp No]=" + LocalEmpId + "", "OleDbConnString_LossOfPay", cmb_Selectmnth.SelectedIndex.ToString(), cmbYear.SelectedItem.ToString());

                    if (dsLOP.Tables[0].Rows.Count > 0)
                    {
                        pnlLOP.Visible = true;
                        dgvLOP.Visible = true;
                        dgvLOP.AutoGenerateColumns = true;
                        bindingSource1.DataSource = dsLOP.Tables[0];
                        dgvLOP.DataSource = bindingSource1;                      
                    }
                    else
                    {
                        pnlLOP.Visible = false;
                        dgvLOP.Visible = false;
                        label2.Visible = true;
                        label2.Text = "No Details Available";

                    }
                }
                catch (Exception ex)
                {
                    GC.ErrorLoging(ex.ToString());
                    pnlLOP.Visible = false;
                    dgvLOP.Visible = false;
                    label2.Visible = true;
                    label2.Text = "No Details Available";
                }

        }

        private void btnview_Click(object sender, EventArgs e)
        {
           
                
                SelectYearMonth();
            
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
        }

        private void lbl_EmpName_Click(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        
        
    }
}
