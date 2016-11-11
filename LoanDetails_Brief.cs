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

   
    public partial class LoanDetails_Brief : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        string LocalEmpId, localEmpName, locationType;
        string localLoanType;

        DataSet dsLoanDetails = new DataSet();
        GeneralClass GC = new GeneralClass();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanDetails_Brief"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="LoanType">Type of the loan.</param>
        /// <remarks></remarks>
        public LoanDetails_Brief(string EmpId, string EmpName, string LoanType, string locallocationType)
        {
                InitializeComponent();
                locationType = locallocationType;
                LocalEmpId = EmpId;
                localEmpName = EmpName;
                lblEmpName.Text = EmpName;
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
               
              // lblDt.Text = DateTime.Now.ToString("dd-MM-yyyy");
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
            try
            {
                dsLoanDetails = GC.ExcelConnectivity("Select * from [Sheet1$] where [Emp No] =" + EmpId + " and [Wage Type] = '" + localLoanType + "'", "OleDbConnString_LoanDetails");
                //retrieving data from LoanDetails sheet
                if (dsLoanDetails.Tables[0].Rows.Count > 0)
                {
                    pnlLOP.Visible = true;
                    dgvLoan.Visible = true;
                    dgvLoan.AutoGenerateColumns = true;
                    bindingSource1.DataSource = dsLoanDetails.Tables[0];
                    dgvLoan.DataSource = bindingSource1;
                    
                   // lblLoanTknAmt.Text = Convert.ToDateTime( dsLoanDetails.Tables[0].Rows[0]["Loan Taken Date"].ToString()).ToShortDateString();
                   // lblLoanAmt.Text = dsLoanDetails.Tables[0].Rows[0]["Loan Amount"].ToString();             
                   //lblInterest.Text = dsLoanDetails.Tables[0].Rows[0]["Interest Percent"].ToString();
                   //// lblNoofInstnts.Text = dsLoanDetails.Tables[0].Rows[0]["No of Installments"].ToString();   //appending data to the controls
                   // lblMonthlyEmi.Text = dsLoanDetails.Tables[0].Rows[0]["Monthly EMI"].ToString();
                   //// lblLoanRecovry.Text = dsLoanDetails.Tables[0].Rows[0]["Loan Recovery"].ToString();
                }
                else
                {
                    pnlLOP.Visible = false;
                    dgvLoan.Visible = false;                   
                    lblerror.Visible = true;
                    lblerror.Text = "No Loans Availed";
                }
            }
            
           catch(Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                pnlLOP.Visible = false;
                dgvLoan.Visible = false;
                lblerror.Visible = true;
                lblerror.Text = "No Loans Availed";
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
            Member_Account ma = new Member_Account(LocalEmpId, localEmpName, locationType);//redirecting to member account form
            ma.Show();
            this.Close();
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
            Loan_Details1 ld = new Loan_Details1(LocalEmpId, localEmpName, localLoanType, locationType); //redirecting to Loan loan details form
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
            Welcome_Screen ws = new Welcome_Screen(); // //redirecting to welcome screen form
            ws.Show();
            this.Close();
        }
    }
}
