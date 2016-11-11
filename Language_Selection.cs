using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Configuration;

namespace Coromandel
{
   
    public partial class Language_Selection : Coromandel.Coromandel_MasterPage
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Language_Selection"/> class.
        /// </summary>
        /// <remarks></remarks>
        string locationType;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
       
        public Language_Selection(string locationlocaltype)
        {
            InitializeComponent();
            locationType = locationlocaltype;

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

        }

        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Handles the Click event of the btnEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            this.Close();
           // System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-IN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InstalledUICulture;
            Employee_Lgn objEL = new Employee_Lgn(locationType);
            objEL.Show();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Location_Selection objLocSel = new Location_Selection();
            objLocSel.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnTelugu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnTelugu_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("te");
            Employee_Lgn objEL = new Employee_Lgn(locationType);
            objEL.Show();
        }
    }
}
