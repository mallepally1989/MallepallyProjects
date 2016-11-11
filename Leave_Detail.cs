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

    
    public partial class Leave_Detail : Coromandel.Coromandel_MasterPage
    {
        string LocalEmpId, localEmpName;
        string locationType;

        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();

        /// <summary>
        /// Initializes a new instance of the Leave_Detail class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Leave_Detail(string EmpId, string EmpName, string locallocationType)
        {
            InitializeComponent();
            LocalEmpId = EmpId;
            lblExName.Text = EmpName;
            localEmpName = EmpName;
            locationType = locallocationType;
           // lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
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
            Member_Account ObjMC = new Member_Account(LocalEmpId, localEmpName,locationType);
            ObjMC.Show();//redirecting to Member account from with  ID and Name
        }
        /// <summary>
        /// Handles the Click event of the btnLeaveBalnc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLeaveBalnc_Click(object sender, EventArgs e)
        {
            this.Close();
            Total_Leaves_Per_Month ObjTLPM = new Total_Leaves_Per_Month(LocalEmpId, localEmpName, locationType);
            ObjTLPM.Show();//redirecting to Total Leaves PerMonth with ID and Name
        }

        /// <summary>
        /// Handles the Click event of the btnLOP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLOP_Click(object sender, EventArgs e)
        {
            this.Close();
            Loss_Of_Pay ObjLOP = new Loss_Of_Pay(LocalEmpId, localEmpName, locationType);
            ObjLOP.Show();//redirecting to Loss Of Pay form with ID and Name
        }

        /// <summary>
        /// Handles the Click event of the btnLeaveHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLeaveHistory_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave_Record ObjLR = new Leave_Record(LocalEmpId, localEmpName, locationType);
            ObjLR.Show();//redirecting to Leave Record form with ID and Name
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
            Welcome_Screen ObjWC = new Welcome_Screen();
            ObjWC.Show();// redirecting to welcome screen form
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
            Member_Account ObjMC = new Member_Account(LocalEmpId, localEmpName,locationType);
            ObjMC.Show();

        }

      }
}
