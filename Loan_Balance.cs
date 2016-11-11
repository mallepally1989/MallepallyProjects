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

   
    public partial class Loan_Balance : Coromandel.Coromandel_MasterPage
    {
        string localEmpId, localEmpName;
        string localLoan;
        string locationtype;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        
        DataSet dsClosingbal = new DataSet();
        GeneralClass GC = new GeneralClass();
        /// <summary>
        /// Initializes a new instance of the <see cref="Loan_Balance"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="LoanType">Type of the loan.</param>
        /// <remarks></remarks>
        public Loan_Balance(string EmpId,string EmpName,string LoanType,string locallocationtype)
        {
            InitializeComponent();
            
                localEmpId = EmpId;
                localEmpName = EmpName;
                lblEmpName.Text = EmpName;  
                localLoan = LoanType;
                if (LoanType == "9HLA")
                {
                    lblloanType.Text = "HOUSING LOAN";
                }
                else if (LoanType == "9PFN")
                {
                    lblloanType.Text = "PF LOAN";
                }
                else if (LoanType == "9VEH")
                {
                    lblloanType.Text = "VEHICLE LOAN";
                }
                else if (LoanType == "9FES")
                {
                    lblloanType.Text = "FESTIVE ADVANCE";
                }
                else if (LoanType == "9SAD")
                {
                    lblloanType.Text = "SALARY ADVANCE";
                }
                else
                {
                    lblloanType.Text = "BENEVOLENT LOAN";
                }
                locationtype = locallocationtype;
               // lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                lblDate.Text = ConfigurationManager.AppSettings.Get("LastUpdatedDate");
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
                      //  dsClosingbal = GC.ExcelConnectivity("select * from [LoanFullDetails$] where [Emp No] = '" + EmpId + "' and [Loan Type]= '" + LoanType + "'", "OleDbConnString_Loan_FullDetails");

                    dsClosingbal = GC.ExcelConnectivity("Select * from [Sheet1$] where [Emp No]= " + localEmpId + " and [Wage Type] = '" + localLoan + "'", "OleDbConnString_LoanDetails");
                        //retrieving closing amount from LoanFullDetails sheet
                        if (dsClosingbal.Tables[0].Rows.Count > 0)
                        {
                           // lblAmtClosingDate.Text = System.DateTime.Now.ToShortDateString();
                            lblLoanBalance.Text = "Your Loan Balance as on date " + ConfigurationManager.AppSettings.Get("LastUpdatedDate") + " is " + dsClosingbal.Tables[0].Rows[0]["Loan Balance"].ToString() + "";
                            
                        }
                        else
                        {
                            lblLoanBalance.Visible = false;
                            lblerror.Visible = true;
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
            Member_Account ma = new Member_Account(localEmpId, localEmpName, locationtype); // redirecting to member account form
            ma.Show();
               
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
            Loan_Details1 ld = new Loan_Details1(localEmpId, localEmpName, localLoan, locationtype); //redirecting to Loan details form
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
            Welcome_Screen ws = new Welcome_Screen(); // redirecting to welcome screen form
            ws.Show();
        }

      

       
    }
}
