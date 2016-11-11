namespace Coromandel
{
    partial class Leave_Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_Summary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblExName = new System.Windows.Forms.Label();
            this.lblUpdatedDt = new System.Windows.Forms.Label();
            this.lblUpdatedDate = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dGVLeaveSummary = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblLeaveREC = new System.Windows.Forms.Label();
            this.pnlLeaveSummary = new System.Windows.Forms.Panel();
            this.LblLeaveType = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.activityMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLeaveSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlLeaveSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Name = "lblHeading";
            // 
            // lblExName
            // 
            resources.ApplyResources(this.lblExName, "lblExName");
            this.lblExName.ForeColor = System.Drawing.Color.Black;
            this.lblExName.Name = "lblExName";
            // 
            // lblUpdatedDt
            // 
            resources.ApplyResources(this.lblUpdatedDt, "lblUpdatedDt");
            this.lblUpdatedDt.ForeColor = System.Drawing.Color.Black;
            this.lblUpdatedDt.Name = "lblUpdatedDt";
            // 
            // lblUpdatedDate
            // 
            resources.ApplyResources(this.lblUpdatedDate, "lblUpdatedDate");
            this.lblUpdatedDate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            resources.ApplyResources(this.btnHome, "btnHome");
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
            this.btnBack.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dGVLeaveSummary
            // 
            this.dGVLeaveSummary.AllowUserToAddRows = false;
            this.dGVLeaveSummary.AllowUserToDeleteRows = false;
            this.dGVLeaveSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVLeaveSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVLeaveSummary.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVLeaveSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dGVLeaveSummary, "dGVLeaveSummary");
            this.dGVLeaveSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVLeaveSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVLeaveSummary.Name = "dGVLeaveSummary";
            this.dGVLeaveSummary.ReadOnly = true;
            this.dGVLeaveSummary.RowHeadersVisible = false;
            this.dGVLeaveSummary.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dGVLeaveSummary.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblLeaveREC
            // 
            resources.ApplyResources(this.lblLeaveREC, "lblLeaveREC");
            this.lblLeaveREC.ForeColor = System.Drawing.Color.Red;
            this.lblLeaveREC.Name = "lblLeaveREC";
            // 
            // pnlLeaveSummary
            // 
            this.pnlLeaveSummary.Controls.Add(this.dGVLeaveSummary);
            resources.ApplyResources(this.pnlLeaveSummary, "pnlLeaveSummary");
            this.pnlLeaveSummary.Name = "pnlLeaveSummary";
            // 
            // LblLeaveType
            // 
            resources.ApplyResources(this.LblLeaveType, "LblLeaveType");
            this.LblLeaveType.ForeColor = System.Drawing.Color.Black;
            this.LblLeaveType.Name = "LblLeaveType";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            resources.ApplyResources(this.btnLogout, "btnLogout");
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
            // Leave_Summary
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.LblLeaveType);
            this.Controls.Add(this.pnlLeaveSummary);
            this.Controls.Add(this.lblLeaveREC);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblUpdatedDate);
            this.Controls.Add(this.lblUpdatedDt);
            this.Controls.Add(this.lblExName);
            this.Controls.Add(this.lblHeading);
            this.Name = "Leave_Summary";
            this.Load += new System.EventHandler(this.Leave_Summary_Load);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblExName, 0);
            this.Controls.SetChildIndex(this.lblUpdatedDt, 0);
            this.Controls.SetChildIndex(this.lblUpdatedDate, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblLeaveREC, 0);
            this.Controls.SetChildIndex(this.pnlLeaveSummary, 0);
            this.Controls.SetChildIndex(this.LblLeaveType, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLeaveSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlLeaveSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblExName;
        private System.Windows.Forms.Label lblUpdatedDt;
        private System.Windows.Forms.Label lblUpdatedDate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dGVLeaveSummary;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblLeaveREC;
        private System.Windows.Forms.Panel pnlLeaveSummary;
        private System.Windows.Forms.Label LblLeaveType;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.BindingSource activityMonitorBindingSource;
    }
}
