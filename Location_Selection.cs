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
    public partial class Location_Selection : Coromandel.Coromandel_MasterPage
    {
        
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        string locationType;

        public Location_Selection()
        {
            InitializeComponent();
            

            try
            {

                _am.WarningMinutes = Convert.ToDouble(ConfigurationManager.AppSettings["WarningMinutes"]);
                _am.MaxMinutesIdle = Convert.ToDouble(ConfigurationManager.AppSettings["MaxMinutesIdle"]);
                //_am.WarningMinutes = 0.2;
                //_am.MaxMinutesIdle = 0.5;
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
        /// Handles the Click event of the btnVishakapatnam control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnVishakapatnam_Click(object sender, EventArgs e)
        {
           // dsLOP = GC.ExcelConnectivity("Select * from [" + cmbYear.SelectedItem + "$] where [Emp No]='" + LocalEmpId + "' and [Month]='" + cmbMonth.SelectedItem + "'", "OleDbConnString_LossOfPay");
            this.Close();
            locationType = "Visakhapatnam";
            Language_Selection objLanSel = new Language_Selection(locationType);
            objLanSel.Show();
            
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            locationType = "Kakinada";
            Language_Selection objLanSel = new Language_Selection(locationType);
            objLanSel.Show();
            
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            locationType = "Ennore";
            this.Close();
            Language_Selection_Tamil ObjLST = new Language_Selection_Tamil(locationType);
            ObjLST.Show();
            
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void button3_Click(object sender, EventArgs e)
        {
            locationType = "Ranipet";
            this.Close();
            Language_Selection_Tamil objLanSel = new Language_Selection_Tamil(locationType);
            objLanSel.Show();
           
        }

        private void Location_Selection_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            
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
            ObjWS.Show();
            
        }

        /// <summary>
        /// Handles the 1 event of the button1_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ObjWs = new Welcome_Screen();
            ObjWs.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            locationType = "CorporateUser";
            this.Close();
            Language_Selection objLanSel = new Language_Selection(locationType);
            objLanSel.Show();
        }
    }
}
