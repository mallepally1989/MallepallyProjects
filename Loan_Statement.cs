using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Coromandel
{
   
    public partial class Loan_Statement : Coromandel.Coromandel_MasterPage
    {
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        string localEmpId, localEmpName, locationType;
      
        string localLoanType;
        DataSet dsLoanStmt = new DataSet();
        GeneralClass GC = new GeneralClass();

        /// <summary>
        /// Initializes a new instance of the <see cref="Loan_Statement"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="LoanType">Type of the loan.</param>
        /// <remarks></remarks>
        public Loan_Statement(string EmpId, string EmpName, string LoanType, string locallocationType)
        {
            InitializeComponent();
            locationType = locallocationType;
            localEmpId = EmpId;
            localEmpName = EmpName;
            lblEname.Text = EmpName;
            localLoanType = LoanType;
            if (LoanType == "9HLA")
            {
                lblLoantype.Text = "HOUSING LOAN";
            }
            else if (LoanType == "9PFN")
            {
                lblLoantype.Text = "PF LOAN";
            }
            else if (LoanType == "9VEH")
            {
                lblLoantype.Text = "VEHICLE LOAN";
            }
            else if (LoanType == "9FES")
            {
                lblLoantype.Text = "FESTIVE ADVANCE";
            }
            else if (LoanType == "9SAD")
            {
                lblLoantype.Text = "SALARY ADVANCE";
            }
            else
            {
                lblLoantype.Text = "BENEVOLENT LOAN";
            }
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
            try
            {
               // dsLoanStmt = GC.ExcelConnectivity("Select * from [LoanFullDetails$] where [Emp No] ='" + EmpId + "' and [Loan Type] = '" + localLoanType + "'", "OleDbConnString_Loan_FullDetails");

                dsLoanStmt = GC.ExcelConnectivity("Select * from [Sheet1$] where [Emp No] =" + EmpId + " and [Wage Type] = '" + LoanType + "'", "OleDbConnString_LoanDetails");


                //retrieving data from LoanFull Details sheet
                if (dsLoanStmt.Tables[0].Rows.Count > 0)
                {
                    lblOpeningBal.Text = dsLoanStmt.Tables[0].Rows[0]["Loan Amount"].ToString();
                    lblLoanRecieved.Text = (Convert.ToDouble(dsLoanStmt.Tables[0].Rows[0]["Loan Amount"]) - Convert.ToDouble(dsLoanStmt.Tables[0].Rows[0]["Loan Balance"])).ToString();
                    lblClosingBal.Text = dsLoanStmt.Tables[0].Rows[0]["Loan Balance"].ToString();
                }
                else
                {
                    lblerror.Visible = true;
                    panelloanstmt.Hide();
                    lblerror.Text = "No Loans Availed";
                }
            }
            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
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
            this.Close();
            Member_Account ma = new Member_Account(localEmpId, localEmpName, locationType); //redirecting to Member account form
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
            Loan_Details1 ld = new Loan_Details1(localEmpId, localEmpName, localLoanType, locationType); //redirecting to Loan details form
            ld.Show();
        }


        /// <summary>
        /// Handles the Load event of the Loan_Statement control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        

        /// <summary>
        /// Handles the Click event of the btnLogout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Screen ws = new Welcome_Screen(); // //redirecting to welcome screen form
            ws.Show();
        }

       
    }
}
