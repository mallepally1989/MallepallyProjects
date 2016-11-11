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
   
    public partial class Loan_Details1 : Coromandel.Coromandel_MasterPage
    {
        string LocalEmpId,localEmpName;
        string locationType;
        string localLoanType;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        /// <summary>
        /// Initializes a new instance of the <see cref="Loan_Details1"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="LoanType">Type of the loan.</param>
        /// <remarks></remarks>
        public Loan_Details1(string EmpId, string EmpName, string LoanType, string locallocationType)
        {
            InitializeComponent();
            LocalEmpId = EmpId;
            lblEmpName.Text = EmpName;
            localEmpName = EmpName;
            localLoanType = LoanType;
            if (LoanType == "9HLA")
            {
                lblLoanType.Text = "HOUSING LOAN";
            }
            else if (LoanType == "9PFN")
            {
                lblLoanType.Text = "PF LOAN";
            }
            else if (LoanType == "9VEH")
            {
                lblLoanType.Text = "VEHICLE LOAN";
            }
            else if (LoanType == "9FES")
            {
                lblLoanType.Text = "FESTIVE ADVANCE";
            }
            else if (LoanType == "9SAD")
            {
                lblLoanType.Text = "SALARY ADVANCE";
            }
            else
            {
                lblLoanType.Text = "BENEVOLENT LOAN";
            }

            locationType = locallocationType;
          
            //lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
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
        /// Handles the Click event of the btnHome control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account ma = new Member_Account(LocalEmpId, localEmpName, locationType); //redirecting to member account form
            ma.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoanTypes lt = new LoanTypes(LocalEmpId, localEmpName, locationType); // redirecting to loanTypes  form
            lt.Show();
        }


        /// <summary>
        /// Handles the Click event of the btnLoanBal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLoanBal_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Balance lb = new Loan_Balance(LocalEmpId, localEmpName, localLoanType, locationType); //redirecting to Loan balance form
            lb.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnLoanStmt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLoanStmt_Click(object sender, EventArgs e)
        {
            this.Close();
            Loan_Statement ls = new Loan_Statement(LocalEmpId, localEmpName, localLoanType, locationType); //redirecting to Loan statement form
            ls.Show();
        }

        /// <summary>
        /// Handles the Click event of the btnLoanHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLoanHistory_Click(object sender, EventArgs e)
        {
            this.Close();
            LoanDetails_Brief ldb = new LoanDetails_Brief(LocalEmpId, localEmpName, localLoanType, locationType); //redirecting to Loan Details form
            ldb.Show();
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
            Welcome_Screen ws = new Welcome_Screen(); // redirecting to member account form
            ws.Show();
        }
    }
}
