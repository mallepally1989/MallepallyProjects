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
   
    public partial class Medical_Expences : Coromandel.Coromandel_MasterPage
    {
        
        DataSet dsMedicalExp = new DataSet();
        GeneralClass GC = new GeneralClass();
       
        string LocalEmpId, localEmpName;
        string locationType;
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();
        /// <summary>
        /// Initializes a new instance of the <see cref="Medical_Expences"/> class.
        /// </summary>
        /// <param name="EmpId">The emp id.</param>
        /// <param name="EmpName">Name of the emp.</param>
        /// <remarks></remarks>
        public Medical_Expences(string EmpId, string EmpName, string locallocationType)
        {
            InitializeComponent();
            LocalEmpId = EmpId;
            lblExName.Text = EmpName;
            localEmpName = EmpName;
            locationType = locallocationType;
            int i;
            double BalanceSum=0;
          //  lblUpdatedDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblUpdatedDate.Text = ConfigurationManager.AppSettings["LastUpdatedDate"];
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
                dsMedicalExp = GC.ExcelConnectivity("select * from [Sheet1$] where [Emp No]='" + EmpId + "'", "OleDbConnString_Medical_Expences_" + "" + locationType + "");

                if (dsMedicalExp.Tables[0].Rows.Count > 0)
                {
                    dGVMedicalExpences.AutoGenerateColumns = true;
                    lblTotalEligibleAmount.Text = dsMedicalExp.Tables[0].Rows[0]["Eligible Amount"].ToString() + " as on  " + dsMedicalExp.Tables[0].Rows[0]["Eligible Amount Date"].ToString();
                    lblAvailbleBalance.Text = dsMedicalExp.Tables[0].Rows[0]["Balance"].ToString();
                    bindingSource1.DataSource = dsMedicalExp.Tables[0];                    
                    dGVMedicalExpences.DataSource = bindingSource1;
                    this.dGVMedicalExpences.Columns["Eligible Amount"].Visible = false;
                    this.dGVMedicalExpences.Columns["Eligible Amount Date"].Visible = false;
                    this.dGVMedicalExpences.Columns["Balance"].Visible = false;
                    this.dGVMedicalExpences.Columns["Emp No"].Visible = false;
                    this.dGVMedicalExpences.Columns["Payroll Area"].Visible = false;

                }
                else
                {
                    pnlMedicalExp.Visible = false;
                    lblError.Visible = true;
                    lblError.Text = "No Data Available";
                    lblAvailBal.Visible = false;
                    lblAvailbleBalance.Visible = false;
                    lblTotalEligibleAmount.Visible = false;
                    lblTotEligibleAmt.Visible = false;
                }
            }
            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                pnlMedicalExp.Visible = false;
                lblError.Visible = true;
                lblError.Text = "No Data Available";
                lblAvailBal.Visible = false;
                lblAvailbleBalance.Visible = false;
                lblTotalEligibleAmount.Visible = false;
                lblTotEligibleAmt.Visible = false;
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
            Member_Account ObjMA = new Member_Account(LocalEmpId, localEmpName,locationType);
            ObjMA.Show();
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
            Member_Account ObjMA = new Member_Account(LocalEmpId, localEmpName, locationType);
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
