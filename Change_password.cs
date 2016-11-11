using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coromandel
{
    public partial class Change_password : Coromandel.Coromandel_MasterPage
    {
        string localEmpId, localEmpName, locallocationType;
        DataSet dslogin = new DataSet();
        GeneralClass GC = new GeneralClass();
        int status;

        public Change_password(string EmpId, string EmpName, string locationType)
        {
            InitializeComponent();
            localEmpId = EmpId;
            localEmpName = EmpName;
            locallocationType = locationType;

        }

        private void Change_password_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_click(object sender, EventArgs e)
        {
            try
            {
                //String pwd = txtCp.Text;
                if (txnewCp.Text == txtCnfrmCp.Text)
                {
                    status = GC.ExcelConnectivityforUpdate("update [Sheet1$] set [Password]= '" + txtCnfrmCp.Text + "'  where [Emp No] ='" + localEmpId + "' and Password='" + txtCp.Text.Trim() + "'", "OleDbConnString_UserLogin_" + "" + locallocationType + "");
                    if (status == 1)
                    {
                        lblerror.Visible=true;
                        lblerror.Text = "Password Changed Successfully.";
                    }
                    else
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "Please Try Again!";
                    }

                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "The New Password and Confirm password doesn't match.";
                    txnewCp.Text = "";
                    txtCnfrmCp.Text = "";
                    txtCnfrmCp.Focus();
                }
            }

            catch (Exception ex)
            {
                GC.ErrorLoging(ex.ToString());
                lblerror.Visible = true;
                lblerror.Text = "Please Relogin";
                txnewCp.Text = "";
                txtCnfrmCp.Text = "";
                txnewCp.Focus();
            }
        }

        private void btnBack_click(object sender, EventArgs e)
        {
            this.Close();
            Member_Account OblMC = new Member_Account(localEmpId, localEmpName, locallocationType);
            OblMC.Show();
        }

        
    }
}
