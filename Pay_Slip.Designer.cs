namespace Coromandel
{
    partial class Pay_Slip1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Slip1));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblExName = new System.Windows.Forms.Label();
            this.lblUpdatedDt = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Selectmnth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.activityMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // lblUpdatedDt
            // 
            resources.ApplyResources(this.lblUpdatedDt, "lblUpdatedDt");
            this.lblUpdatedDt.ForeColor = System.Drawing.Color.Black;
            this.lblUpdatedDt.Name = "lblUpdatedDt";
            // 
            // lbldate
            // 
            resources.ApplyResources(this.lbldate, "lbldate");
            this.lbldate.ForeColor = System.Drawing.Color.Black;
            this.lbldate.Name = "lbldate";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.cmb_Selectmnth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMonth, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // cmb_Selectmnth
            // 
            this.cmb_Selectmnth.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            resources.ApplyResources(this.cmb_Selectmnth, "cmb_Selectmnth");
            this.cmb_Selectmnth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Selectmnth.Name = "cmb_Selectmnth";
            // 
            // lblMonth
            // 
            resources.ApplyResources(this.lblMonth, "lblMonth");
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Name = "lblMonth";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            resources.ApplyResources(this.btn_Back, "btn_Back");
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::Coromandel.Properties.Resources.ButtonNames;
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.cmb_Year, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // cmb_Year
            // 
            this.cmb_Year.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            resources.ApplyResources(this.cmb_Year, "cmb_Year");
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.Name = "cmb_Year";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Name = "lblError";
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
            // Pay_Slip1
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblUpdatedDt);
            this.Controls.Add(this.lblExName);
            this.Controls.Add(this.lblHeading);
            this.Name = "Pay_Slip1";
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblExName, 0);
            this.Controls.SetChildIndex(this.lblUpdatedDt, 0);
            this.Controls.SetChildIndex(this.lbldate, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.btn_Back, 0);
            this.Controls.SetChildIndex(this.btnView, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.lblError, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
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
        private System.Windows.Forms.Label lblUpdatedDt;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmb_Selectmnth;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.BindingSource activityMonitorBindingSource;

    }
}
