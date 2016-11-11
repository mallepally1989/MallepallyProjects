    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Microsoft.VisualBasic.PowerPacks.Printing;
    using System.Drawing.Printing;
    using System.Configuration;
    namespace Coromandel
    {
    public partial class View_Pay_slip : Form
    {

        string localEmpId, localEmpName, locationType;
        DataSet dsPayslip = new DataSet();
        GeneralClass GC = new GeneralClass();
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
        Welcome_Screen ObjWS = new Welcome_Screen();

        public View_Pay_slip(string EmpId, string EmpName, string year, string month, string locallocationType)
        {
            InitializeComponent();
            localEmpId = EmpId;
            localEmpName = EmpName;
            locationType = locallocationType;

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

                dsPayslip = GC.ExcelConnectivityforPayslip("Select * from [Sheet1$] where [Emp No]='" + EmpId + "'", "OleDbConnString_Payslip", month, year, locallocationType);
                //retrieving data from payslip_part_Empdetails sheet
            if (dsPayslip.Tables[0].Rows.Count > 0)
            {
            // Personal Info start

                lbl_Address.Text = "Beach Road,Kakinada,533003";
                lblHelfDesk.Text = "payhelpdesk@coromandel.murugappa.com";
                panel1.Visible = true;
                lblpayslipdate.Text = dsPayslip.Tables[0].Rows[0]["Month"].ToString() + "," + year;                

                if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Emp No"]) != 0)
                {
                    lblEmpNo.Text = dsPayslip.Tables[0].Rows[0]["Emp No"].ToString();
                }
                else
                {
                    lblEmpNo.Visible = false;
                    label2.Visible = false;
                }

                lblEmpName.Text = dsPayslip.Tables[0].Rows[0]["Employee Name"].ToString();

                lblDesignation.Text = dsPayslip.Tables[0].Rows[0]["Designation"].ToString();

                lblDivision.Text = dsPayslip.Tables[0].Rows[0]["Cost Center Desc"].ToString();

                lblDepartment.Text = dsPayslip.Tables[0].Rows[0]["Department"].ToString();

                //lbl_Address.Text = dsPayslip.Tables[0].Rows[0]["Address"].ToString();

               // lblLocation.Text = dsPayslip.Tables[0].Rows[0]["Location"].ToString();

                //lblFather_HusbandName.Text = dsPayslip.Tables[0].Rows[0]["Father/Husband Name"].ToString();

                lblGrade.Text = dsPayslip.Tables[0].Rows[0]["Grade"].ToString();

                //lblHelfDesk.Text = dsPayslip.Tables[0].Rows[0]["Help Desk"].ToString();

                lblPaymentType.Text = dsPayslip.Tables[0].Rows[0]["Payment Method"].ToString();

                //lblDOB.Text = Convert.ToDateTime(dsPayslip.Tables[0].Rows[0]["Date of Birth"].ToString()).ToShortDateString();

                lblDateofJoining.Text = dsPayslip.Tables[0].Rows[0]["D O J"].ToString();

                if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["DaysWorked"]) != 0)
                {
                    lblDaysPresent.Text = dsPayslip.Tables[0].Rows[0]["DaysWorked"].ToString();
                }
                else
                {
                    lblDaysPresent.Visible = false;
                    label37.Visible = false;
                }

                //lblDaysPresent.Text = dsPayslip.Tables[0].Rows[0]["Emp_No"].ToString();

                //lblBankName.Text = dsPayslip.Tables[0].Rows[0]["Bank Name"].ToString();

                //lblPanNo.Text = dsPayslip.Tables[0].Rows[0]["PAN No"].ToString();

                //if (Convert.ToInt64(dsPayslip.Tables[0].Rows[0]["Bank Account No"]) != 0)
                //{
                //    lblBankAccNo.Text = dsPayslip.Tables[0].Rows[0]["Bank Account No"].ToString();
                //}
                //else
                //{
                    //lblBankAccNo.Visible = false;
                    //label12.Visible = false;
                //}
                //if (Convert.ToInt64(dsPayslip.Tables[0].Rows[0]["ESI No"]) != 0)
                //{
                //    lblESINo.Text = dsPayslip.Tables[0].Rows[0]["ESI No"].ToString();
                //}
                //else
                //{
                    //lblESINo.Visible = false;
                    //label34.Visible = false;
                //}
                //if (Convert.ToInt64(dsPayslip.Tables[0].Rows[0]["PF No"]) != 0)
                //{
                //    lblPFNo.Text = dsPayslip.Tables[0].Rows[0]["PF No"].ToString();
                //}
                //else
                //{
                //    lblPFNo.Visible = false;
                //    label62.Visible = false;
                //}

    // Personal Info end

                // Earning 

                if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Basic"]) != 0)
                    {
                        lblBasic.Text = dsPayslip.Tables[0].Rows[0]["Basic"].ToString();
                    }
                    else
                    {
                        lblBasic.Visible = false;
                        label15.Visible = false; 
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Special Pay"]) != 0)
                    {
                        lblPerPay.Text = dsPayslip.Tables[0].Rows[0]["Special Pay"].ToString();
                    }
                    else
                    {
                        lblPerPay.Visible = false;
                        label24.Visible = false; 
                    }
                    
                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Variable DA"]) != 0)
                    {
                        lblVDA.Text = dsPayslip.Tables[0].Rows[0]["Variable DA"].ToString();
                    }
                    else
                    {
                        lblVDA.Visible = false;
                        label23.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Education Allowance"]) != 0)
                    {
                        lblEduAllow.Text = dsPayslip.Tables[0].Rows[0]["Education Allowance"].ToString();
                    }
                    else
                    {
                        lblEduAllow.Visible = false;
                        label19.Visible = false;
                    }
                 if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Fixed Local Travel Expens"]) != 0)
                    {
                        lblFLTE.Text = dsPayslip.Tables[0].Rows[0]["Fixed Local Travel Expens"].ToString();
                    }
                    else
                    {
                        lblFLTE.Visible = false;
                        label76.Visible = false;
                    }
                 if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Intrest Subsidy kakinada"]) != 0)
                 {
                     lblINTSUB.Text = dsPayslip.Tables[0].Rows[0]["Intrest Subsidy kakinada"].ToString();
                 }
                 else
                 {
                     lblINTSUB.Visible = false;
                     label95.Visible = false;
                 }
                

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["House Rent Allowance"]) != 0)
                    {
                        lblHRA.Text = dsPayslip.Tables[0].Rows[0]["House Rent Allowance"].ToString();
                    }
                    else
                    {
                        lblHRA.Visible = false;
                        label25.Visible = false;
                    }
                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Personal Allowance"]) != 0)
                    {
                        lblPersonalAllowance.Text = dsPayslip.Tables[0].Rows[0]["Personal Allowance"].ToString();
                    }
                    else
                    {
                        lblPersonalAllowance.Visible = false;
                        label70.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Washing Allowance"]) != 0)
                    {
                        lblwashAllow.Text = dsPayslip.Tables[0].Rows[0]["Washing Allowance"].ToString();
                    }
                    else
                    {
                        lblwashAllow.Visible = false;
                        label71.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Leave Encashment"]) != 0)
                    {
                        lblLeaveEncash.Text = dsPayslip.Tables[0].Rows[0]["Leave Encashment"].ToString();
                    }
                    else
                    {
                        lblLeaveEncash.Visible = false;
                        label72.Visible = false;
                    }


                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Medical Reimbursement"]) != 0)
                    {
                        lblMedRemb.Text = dsPayslip.Tables[0].Rows[0]["Medical Reimbursement"].ToString();
                    }
                    else
                    {
                        lblMedRemb.Visible = false;
                        label73.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Overtime Kakinada(NMS)"]) != 0)
                    {
                        lblOTHours.Text = dsPayslip.Tables[0].Rows[0]["Overtime Kakinada(NMS)"].ToString();
                    }
                    else
                    {
                        lblOTHours.Visible = false;
                        label74.Visible = false;
                    }
                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Production Incentive"]) != 0)
                    {
                        lblIncentive.Text = dsPayslip.Tables[0].Rows[0]["Production Incentive"].ToString();
                    }
                    else
                    {
                        lblIncentive.Visible = false;
                        label75.Visible = false;
                    }
                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Night Shift allowance"]) != 0)
                    {
                        lblSHFTAllow.Text = dsPayslip.Tables[0].Rows[0]["Night Shift allowance"].ToString();
                    }
                    else
                    {
                        lblSHFTAllow.Visible = false;
                        label27.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Round of Adjustments"]) != 0)
                    {
                        lblRoundAdj.Text = dsPayslip.Tables[0].Rows[0]["Round of Adjustments"].ToString();
                    }
                    else
                    {
                        lblRoundAdj.Visible = false;
                        label29.Visible = false;
                    }
                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Special Allowance"]) != 0)
                    {
                        lblsplAllow.Text = dsPayslip.Tables[0].Rows[0]["Special Allowance"].ToString();
                    }
                    else
                    {
                        lblsplAllow.Visible = false;
                        label96.Visible = false;
                    }

                    lblTotalEarnings.Text = dsPayslip.Tables[0].Rows[0]["Gross Salary"].ToString();



                //Deductions

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["P Fund"]) != 0)
                    {
                        lblProvFund.Text = dsPayslip.Tables[0].Rows[0]["P Fund"].ToString();
                    }
                    else
                    {
                        lblProvFund.Visible = false;
                        label62.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["VPF"]) != 0)
                    {
                        lblVpf.Text = dsPayslip.Tables[0].Rows[0]["VPF"].ToString();
                    }
                    else
                    {
                        lblVpf.Visible = false;
                        label77.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["ProfTax"]) != 0)
                    {
                        lblProfTax.Text = dsPayslip.Tables[0].Rows[0]["ProfTax"].ToString();
                    }
                    else
                    {
                        lblProfTax.Visible = false;
                        label88.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["T D S"]) != 0)
                    {
                        lblIncomeTax.Text = dsPayslip.Tables[0].Rows[0]["T D S"].ToString();
                    }
                    else
                    {
                        lblIncomeTax.Visible = false;
                        label89.Visible = false;
                    }                   

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Cooperative Society Rec"]) != 0)
                    {
                        lblCoopRec.Text = dsPayslip.Tables[0].Rows[0]["Cooperative Society Rec"].ToString();
                    }
                    else
                    {
                        lblCoopRec.Visible = false;
                        label90.Visible = false;
                    }

                    //if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Fest.Adv Recovery Repaynt"]) != 0)
                    //{
                    //    lblFesAdv.Text = dsPayslip.Tables[0].Rows[0]["Fest.Adv Recovery Repaynt"].ToString();
                    //}
                    //else
                    //{
                    lblFesAdv.Visible = false;
                    label91.Visible = false;
                    //}

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Benevolent Fund Deduction"]) != 0)
                    {
                        lblBenFund.Text = dsPayslip.Tables[0].Rows[0]["Benevolent Fund Deduction"].ToString();
                    }
                    else
                    {
                        lblBenFund.Visible = false;
                        label65.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Life Insurance Cor india"]) != 0)
                    {
                        lblLIC_SSE.Text = dsPayslip.Tables[0].Rows[0]["Life Insurance Cor india"].ToString();
                    }
                    else
                    {
                        lblLIC_SSE.Visible = false;
                        label68.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Union Fund Deductions"]) != 0)
                    {
                        lblUnionDed.Text = dsPayslip.Tables[0].Rows[0]["Union Fund Deductions"].ToString();
                    }
                    else
                    {
                        lblUnionDed.Visible = false;
                        label93.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Super Annuation"]) != 0)
                    {
                        lblSAF.Text = dsPayslip.Tables[0].Rows[0]["Super Annuation"].ToString();
                    }
                    else
                    {
                        lblSAF.Visible = false;
                        label97.Visible = false;
                    }

                    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Round of Recovery"]) != 0)
                    {
                        lblRoundDed.Text = dsPayslip.Tables[0].Rows[0]["Round of Recovery"].ToString();
                    }
                    else
                    {
                        lblRoundDed.Visible = false;
                        label69.Visible = false;
                    }

                    lblTotalDeduction.Text = dsPayslip.Tables[0].Rows[0]["Deduction"].ToString();
                    //net salary
                    lblNetPay.Text = dsPayslip.Tables[0].Rows[0]["Net Salary"].ToString();


                //Estimated Tax
                
                //        lblConvenyanceAllow.Text = dsPayslip.Tables[0].Rows[0]["Conveyance Allowance"].ToString();

                //        if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Conveyance Allowance(RP)"]) != 0)
                //    {
                //        lblConAllow.Text = dsPayslip.Tables[0].Rows[0]["Conveyance Allowance(RP)"].ToString();
                //    }
                //    else
                //    {
                //        lblConAllow.Visible = false;
                //        label26.Visible = false;
                //    }


                //        lblDeduction_SOc.Text = dsPayslip.Tables[0].Rows[0]["Deduction"].ToString();


                //        lblDeduction_SO.Text = dsPayslip.Tables[0].Rows[0]["Deduction"].ToString();




                       
                    
                //    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Death Relief fund"]) != 0)
                //{
                //    lblDrf.Text = dsPayslip.Tables[0].Rows[0]["Death Relief fund"].ToString();
                //}
                //else
                //{
                //    lblDrf.Visible = false;
                //    label67.Visible = false;
                //}

                 

                //    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["LicHflvsp"]) != 0)
                //{
                //    lblLIC_SSE.Text = dsPayslip.Tables[0].Rows[0]["LicHflvsp"].ToString();
                //}
                //else
                //{
                //    lblLIC_SSE.Visible = false;
                //    label68.Visible = false;
                //}

                //    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Round of Recovery"]) != 0)
                //{
                //    lblRoundDed.Text = dsPayslip.Tables[0].Rows[0]["Round of Recovery"].ToString();
                //}
                //else
                //{
                //    lblRoundDed.Visible = false;
                //    label69.Visible = false;
                //}

               
              

                //lblTaxScEc.Text=(Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Tax Payable"])) 
                //                 +  (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Surcharge"])) +
                //                 (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Education Cess"])).ToString();
                
               
               
               
             

                
                //    lblTaxPayable.Text = dsPayslip.Tables[0].Rows[0]["Tax Payable"].ToString();
                

                //if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["SPS"]) != 0)
                //{
                //    lblSPS.Text = dsPayslip.Tables[0].Rows[0]["SPS"].ToString();
                //}
                //else
                //{
                //    lblSPS.Visible = false;
                //    label28.Visible = false;
                //}
                //lblProvFund.Text = dsPayslip.Tables[0].Rows[0]["P Fund"].ToString();
                //if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["E S I"]) != 0)
                //{
                //    lblESI.Text = dsPayslip.Tables[0].Rows[0]["E S I"].ToString();
                //}
                //else
                //{
                //    lblESI.Visible = false;
                //    label63.Visible = false;
                //}
                //if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["Other Deductions"]) != 0)
                //{
                //    lblOtherDed.Text = dsPayslip.Tables[0].Rows[0]["Other Deductions"].ToString();
                //}
                //else
                //{
                //    lblOtherDed.Visible = false;
                //    label64.Visible = false;
                //}
                //    lblPrvEmpOth.Text = dsPayslip.Tables[0].Rows[0]["Prev Employment/Other"].ToString();

                //lblHouseRentAllow.Text = dsPayslip.Tables[0].Rows[0]["House Rent Allowance"].ToString();


                //lblLeaveTravelAllow.Text = dsPayslip.Tables[0].Rows[0]["Leave Traval Allowance"].ToString();
               
               
                //    lblEmployementTax.Text = dsPayslip.Tables[0].Rows[0]["Employment Tax"].ToString();


                   

                //    if (Convert.ToInt32(dsPayslip.Tables[0].Rows[0]["LOPDays"]) != 0)
                //{
                //    lblLOPDays.Text = dsPayslip.Tables[0].Rows[0]["LOPDays"].ToString();
                //}
                //else
                //{
                //    lblLOPDays.Visible = false;
                //    label36.Visible = false;
                //}

                //    lblWasingAllow.Text = dsPayslip.Tables[0].Rows[0]["Washing Allowance"].ToString();
                   
               
                
                //    lblHousePrprtyDet.Text = dsPayslip.Tables[0].Rows[0]["House Property Details"].ToString();
               
                
                //    lblTaxOnTaxableSalary.Text = dsPayslip.Tables[0].Rows[0]["Tax on Taxable Salary"].ToString();
                
              
                //    lblSurcharge.Text = dsPayslip.Tables[0].Rows[0]["Surcharge"].ToString();

                //    lblEducationCess.Text = dsPayslip.Tables[0].Rows[0]["Education Allowance"].ToString();

                //    lblTDSDedSoFar.Text = dsPayslip.Tables[0].Rows[0]["Income Tax Deduction"].ToString();

                //    lblTaxDedPerMonth.Text = dsPayslip.Tables[0].Rows[0]["T D S"].ToString();

                

                //    lblTaxableSalary.Text = dsPayslip.Tables[0].Rows[0]["Net Salary"].ToString();
               

             

                //lblGrossannualSalary.Text = dsPayslip.Tables[0].Rows[0]["Gross Salary"].ToString();
               
            }
            else
            {
                // MessageBox.Show("No Details Available");
                panel1.Visible = false;
                lblerror.Text = "No Details Available";
            }


                //gross salary
            //
                //total deduction
           


            }
            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                panel1.Visible = false;
                lblerror.Text = "No Details Available";
            }
        }

        void am_Idle(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    Pay_Slip1 ps = new Pay_Slip1(localEmpId, localEmpName, locationType);
        //    ps.Show();
        //    this.Close();

        //}
        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    PaperSize pp = new PaperSize("A4", 1600, 900);
        //    printForm1.PrinterSettings.DefaultPageSettings.PaperSize = pp;

        //    printForm1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0,0,0,0);
        //    printForm1.Print();
        //    // printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
        //    //printForm1.Print(this, PrintForm.PrintOption.CompatibleModeClientAreaOnly);
        //}

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            PaperSize pp = new PaperSize("A4", 1500, 1024);
            printForm1.PrinterSettings.DefaultPageSettings.PaperSize = pp;

            printForm1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            printForm1.Print();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Pay_Slip1 ps = new Pay_Slip1(localEmpId, localEmpName, locationType);
            ps.Show();
            this.Close();
        }

       
    }
    }
