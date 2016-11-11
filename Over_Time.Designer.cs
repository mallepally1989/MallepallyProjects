namespace Coromandel
{
    partial class Over_Time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Over_Time));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblExName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblupdateddate = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOT = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlOT = new System.Windows.Forms.Panel();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.cmbSelectYear = new System.Windows.Forms.ComboBox();
            this.cmbSelectMonth = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblselyear = new System.Windows.Forms.Label();
            this.lblSelMonth = new System.Windows.Forms.Label();
            this.lblcomboxerror = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.activityMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlOT.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // lblupdateddate
            // 
            resources.ApplyResources(this.lblupdateddate, "lblupdateddate");
            this.lblupdateddate.ForeColor = System.Drawing.Color.Black;
            this.lblupdateddate.Name = "lblupdateddate";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
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
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvOT
            // 
            this.dgvOT.AllowUserToAddRows = false;
            this.dgvOT.AllowUserToDeleteRows = false;
            this.dgvOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOT.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvOT, "dgvOT");
            this.dgvOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOT.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOT.Name = "dgvOT";
            this.dgvOT.RowHeadersVisible = false;
            this.dgvOT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOT.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOT.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvOT.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // pnlOT
            // 
            this.pnlOT.Controls.Add(this.dgvOT);
            resources.ApplyResources(this.pnlOT, "pnlOT");
            this.pnlOT.Name = "pnlOT";
            // 
            // lblErrorMsg
            // 
            resources.ApplyResources(this.lblErrorMsg, "lblErrorMsg");
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Name = "lblErrorMsg";
            // 
            // cmbSelectYear
            // 
            resources.ApplyResources(this.cmbSelectYear, "cmbSelectYear");
            this.cmbSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectYear.FormattingEnabled = true;
            this.cmbSelectYear.Name = "cmbSelectYear";
            // 
            // cmbSelectMonth
            // 
            resources.ApplyResources(this.cmbSelectMonth, "cmbSelectMonth");
            this.cmbSelectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectMonth.FormattingEnabled = true;
            this.cmbSelectMonth.Name = "cmbSelectMonth";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectYear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblselyear, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblselyear
            // 
            resources.ApplyResources(this.lblselyear, "lblselyear");
            this.lblselyear.ForeColor = System.Drawing.Color.Black;
            this.lblselyear.Name = "lblselyear";
            // 
            // lblSelMonth
            // 
            resources.ApplyResources(this.lblSelMonth, "lblSelMonth");
            this.lblSelMonth.ForeColor = System.Drawing.Color.Black;
            this.lblSelMonth.Name = "lblSelMonth";
            // 
            // lblcomboxerror
            // 
            resources.ApplyResources(this.lblcomboxerror, "lblcomboxerror");
            this.lblcomboxerror.ForeColor = System.Drawing.Color.Red;
            this.lblcomboxerror.Name = "lblcomboxerror";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Transparent;
            this.btnview.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            this.btnview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnview, "btnview");
            this.btnview.ForeColor = System.Drawing.Color.Black;
            this.btnview.Name = "btnview";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.lblSelMonth, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbSelectMonth, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::Coromandel.Properties.Resources.Login;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Over_Time
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.lblcomboxerror);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.pnlOT);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblupdateddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExName);
            this.Controls.Add(this.lblHeading);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "Over_Time";
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblExName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblupdateddate, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.pnlOT, 0);
            this.Controls.SetChildIndex(this.lblErrorMsg, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.lblcomboxerror, 0);
            this.Controls.SetChildIndex(this.btnview, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlOT.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblExName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblupdateddate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOT;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlOT;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ComboBox cmbSelectYear;
        private System.Windows.Forms.ComboBox cmbSelectMonth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblselyear;
        private System.Windows.Forms.Label lblSelMonth;
        private System.Windows.Forms.Label lblcomboxerror;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.BindingSource activityMonitorBindingSource;
    }
}
