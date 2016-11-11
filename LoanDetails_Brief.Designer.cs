namespace Coromandel
{
    partial class LoanDetails_Brief
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanDetails_Brief));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblUpdatingDt = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.activityMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLOP = new System.Windows.Forms.Panel();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).BeginInit();
            this.pnlLOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Name = "lblHeading";
            // 
            // lblEmpName
            // 
            resources.ApplyResources(this.lblEmpName, "lblEmpName");
            this.lblEmpName.ForeColor = System.Drawing.Color.Black;
            this.lblEmpName.Name = "lblEmpName";
            // 
            // lblUpdatingDt
            // 
            resources.ApplyResources(this.lblUpdatingDt, "lblUpdatingDt");
            this.lblUpdatingDt.ForeColor = System.Drawing.Color.Black;
            this.lblUpdatingDt.Name = "lblUpdatingDt";
            // 
            // lblDt
            // 
            resources.ApplyResources(this.lblDt, "lblDt");
            this.lblDt.ForeColor = System.Drawing.Color.Black;
            this.lblDt.Name = "lblDt";
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
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblerror
            // 
            resources.ApplyResources(this.lblerror, "lblerror");
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Name = "lblerror";
            // 
            // lblLoanType
            // 
            resources.ApplyResources(this.lblLoanType, "lblLoanType");
            this.lblLoanType.ForeColor = System.Drawing.Color.Black;
            this.lblLoanType.Name = "lblLoanType";
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
            // pnlLOP
            // 
            resources.ApplyResources(this.pnlLOP, "pnlLOP");
            this.pnlLOP.Controls.Add(this.dgvLoan);
            this.pnlLOP.Name = "pnlLOP";
            // 
            // dgvLoan
            // 
            resources.ApplyResources(this.dgvLoan, "dgvLoan");
            this.dgvLoan.AllowUserToAddRows = false;
            this.dgvLoan.AllowUserToDeleteRows = false;
            this.dgvLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoan.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoan.RowHeadersVisible = false;
            this.dgvLoan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLoan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLoan.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // LoanDetails_Brief
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.pnlLOP);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoanType);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.lblUpdatingDt);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblHeading);
            this.Name = "LoanDetails_Brief";
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblEmpName, 0);
            this.Controls.SetChildIndex(this.lblUpdatingDt, 0);
            this.Controls.SetChildIndex(this.lblDt, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblerror, 0);
            this.Controls.SetChildIndex(this.lblLoanType, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.pnlLOP, 0);
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).EndInit();
            this.pnlLOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblUpdatingDt;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.BindingSource activityMonitorBindingSource;
        private System.Windows.Forms.Panel pnlLOP;
        private System.Windows.Forms.DataGridView dgvLoan;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}
