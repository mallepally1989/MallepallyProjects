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
    public partial class Language_Selection_Tamil : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        string locationType;
        
        public Language_Selection_Tamil(string localLocationType)
        {
            InitializeComponent();
            locationType = localLocationType;
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

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InstalledUICulture;
            Employee_Lgn objEL = new Employee_Lgn(locationType);
            this.Close();
            objEL.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Location_Selection ObjLS = new Location_Selection();
            ObjLS.Show();
        }

        private void btnTamil_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ta");
            Employee_Lgn objEL = new Employee_Lgn (locationType);
            this.Close();
            objEL.Show();
        }

        
    }
}
