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
    
    public partial class Pay_Slip1 : Coromandel.Coromandel_MasterPage
    {
        
        string localEmpId;
        string locationType;
        string localEmpName;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        /// <summary>
        /// Initializes a new instance of the <see cref="Pay_Slip1"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Pay_Slip1(string EmpId, string EmpName, string locallocationType)
        {
            InitializeComponent();
            localEmpId = EmpId;
            lblExName.Text = EmpName;
            localEmpName = EmpName;
            locationType = locallocationType;
           // lbldate.Text = DateTime.Now.ToString("dd-MM-yyyy");

            lbldate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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
            int year=DateTime.Now.Year;
            int year1 = year - 1;
            int year2 = year - 2;

            // appending items (Years) to Combobox
            cmb_Year.Items.Insert(0, "--Select--");
            cmb_Year.Items.Insert(1, year.ToString());
            cmb_Year.Items.Insert(2, year1.ToString());
            cmb_Year.Items.Insert(3, year2.ToString());
            cmb_Year.SelectedIndex = 0;
            // appending items (Months) to Combobox
            cmb_Selectmnth.Items.Insert(0, "--Select--");
            cmb_Selectmnth.Items.Insert(1, "January");
            cmb_Selectmnth.Items.Insert(2, "February");
            cmb_Selectmnth.Items.Insert(3, "March");
            cmb_Selectmnth.Items.Insert(4, "April");
            cmb_Selectmnth.Items.Insert(5, "May");
            cmb_Selectmnth.Items.Insert(6, "June");
            cmb_Selectmnth.Items.Insert(7, "July");
            cmb_Selectmnth.Items.Insert(8, "August");
            cmb_Selectmnth.Items.Insert(9, "September");
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
            Member_Account ObjMC = new Member_Account(localEmpId, localEmpName,locationType);
            ObjMC.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmb_Year.SelectedIndex == 0 && cmb_Selectmnth.SelectedIndex == 0)
            {
                lblError.Text = "Please Select Year And Month";
                
            }
            else if (cmb_Selectmnth.SelectedIndex == 0)
            {
                lblError.Text = "Please Select Month";

            }
            else if (cmb_Year.SelectedIndex == 0)
            {
                lblError.Text = "Please Select Year";
            }
            else if (cmb_Year.SelectedIndex != 0 && cmb_Selectmnth.SelectedIndex != 0)
            {
                string selectedyear = cmb_Year.SelectedItem.ToString();
                string selectedmonth = cmb_Selectmnth.SelectedIndex.ToString();
                this.Close();
                View_Pay_slip ObjPS = new View_Pay_slip(localEmpId, localEmpName, selectedyear, selectedmonth, locationType);
                ObjPS.Show();
            }
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
            Member_Account ObjMA = new Member_Account(localEmpId,localEmpName,locationType);
            ObjMA.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWS = new Welcome_Screen();
            ObjWS.Show(); // Redirecting to Welcome Screen form 
        }
    }
}
