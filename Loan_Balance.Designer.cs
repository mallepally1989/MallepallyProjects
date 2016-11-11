namespace Coromandel
{
    partial class Loan_Balance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan_Balance));
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblloanType = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.activityMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLoanBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // lblEmpName
            // 
            resources.ApplyResources(this.lblEmpName, "lblEmpName");
            this.lblEmpName.ForeColor = System.Drawing.Color.Black;
            this.lblEmpName.Name = "lblEmpName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Name = "lblDate";
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btn_Back
            // 
            resources.ApplyResources(this.btn_Back, "btn_Back");
            this.btn_Back.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lblerror
            // 
            resources.ApplyResources(this.lblerror, "lblerror");
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Name = "lblerror";
            // 
            // lblloanType
            // 
            resources.ApplyResources(this.lblloanType, "lblloanType");
            this.lblloanType.ForeColor = System.Drawing.Color.Black;
            this.lblloanType.Name = "lblloanType";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLoanBalance
            // 
            resources.ApplyResources(this.lblLoanBalance, "lblLoanBalance");
            this.lblLoanBalance.Name = "lblLoanBalance";
            // 
            // Loan_Balance
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblloanType);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lblLoanBalance);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.label1);
            this.Name = "Loan_Balance";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblEmpName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.btn_Back, 0);
            this.Controls.SetChildIndex(this.lblLoanBalance, 0);
            this.Controls.SetChildIndex(this.lblerror, 0);
            this.Controls.SetChildIndex(this.lblloanType, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblloanType;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.BindingSource activityMonitorBindingSource;
        private System.Windows.Forms.Label lblLoanBalance;
    }
}
