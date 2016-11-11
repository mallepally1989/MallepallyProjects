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
    
    public partial class LoanTypes : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        string localEmpID, localEmpName;
        // initailizing static values  and passing the values to specific pages

       
        string localHousigLoan = "9HLA";


        string localPFLoan = "9PFN";


        string localVehicleLoan = "9VEH";


        string localFestiveAdvance = "9FES";


        string localSalaryAdvance = "9SAD";

        
        string localBenevolentLoan = "BENEVOLENT LOAN";
        string locationtype;

        
        //string localStore = "STORE";

       
        string localSociety = "SOCIETY";
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanTypes"/> class.
        /// </summary>
        /// <param name="EmpID">The emp ID.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public LoanTypes(string EmpID,string EmpName,string locallocationtype)
        {
            InitializeComponent();
            lblEmpName.Text = EmpName;
            localEmpID = EmpID;
            localEmpName = EmpName;
            locationtype = locallocationtype;

            //lblDt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblDt.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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
        /// redirecting to loan details  form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPFLoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName, localPFLoan,locationtype);
            ld.Show();
        }
        /// <summary>
        /// redirecting to member account  form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account ma = new Member_Account(localEmpID, localEmpName,locationtype);
            ma.Show();
        }
        /// <summary>
        /// redirecting to member account  form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account ma = new Member_Account(localEmpID,localEmpName,locationtype);
            ma.Show();
        }

        /// <summary>
        /// redirecting to loan details form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnHousingLoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName, localHousigLoan, locationtype);
            ld.Show();
        }
        /// <summary>
        /// redirecting to loan details form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnVehicleLoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName, localVehicleLoan, locationtype);
            ld.Show();
        }

        /// <summary>
        /// redirecting to loan details form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBenevolentLoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName,localBenevolentLoan,locationtype);
            ld.Show();
        }

        /// <summary>
        /// redirecting to loan details form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>

        private void btnSalaryAdv_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName, localSalaryAdvance, locationtype);
            ld.Show();
        }

        /// <summary>
        /// redirecting to loan details form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnFestiveAdv_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName, localFestiveAdvance, locationtype);
            ld.Show();
        }

        /// <summary>
        /// redirecting to loan details form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        //private void btnStoreSociety_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName,localStore);
        //    ld.Show();
        //}

        /// <summary>
        /// Handles the Click event of the btnSociety control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSociety_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Details1 ld = new Loan_Details1(localEmpID, localEmpName, localSociety, locationtype);
            ld.Show();
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
            Welcome_Screen ws = new Welcome_Screen();
            ws.Show();
        }

        
     
    }
}
