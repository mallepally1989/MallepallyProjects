namespace Coromandel
{
    partial class Language_Selection
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
            this.btnEnglish = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnTelugu = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.activityMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackgroundImage = global::Coromandel.Properties.Resources.ButtonNames;
            this.btnEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnglish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnglish.FlatAppearance.BorderSize = 0;
            this.btnEnglish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEnglish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.Black;
            this.btnEnglish.Location = new System.Drawing.Point(349, 347);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(238, 70);
            this.btnEnglish.TabIndex = 3;
            this.btnEnglish.Text = "ENGLISH";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(440, 259);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(413, 35);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "PLEASE SELECT THE LANGUAGE";
            // 
            // btnTelugu
            // 
            this.btnTelugu.BackgroundImage = global::Coromandel.Properties.Resources.ButtonNamesReverse;
            this.btnTelugu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelugu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelugu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTelugu.FlatAppearance.BorderSize = 0;
            this.btnTelugu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTelugu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTelugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelugu.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelugu.ForeColor = System.Drawing.Color.Black;
            this.btnTelugu.Location = new System.Drawing.Point(688, 350);
            this.btnTelugu.Name = "btnTelugu";
            this.btnTelugu.Size = new System.Drawing.Size(238, 70);
            this.btnTelugu.TabIndex = 5;
            this.btnTelugu.Text = "తెలుగు";
            this.btnTelugu.UseVisualStyleBackColor = true;
            this.btnTelugu.Click += new System.EventHandler(this.btnTelugu_Click);
            // 
            // btnBck
            // 
            this.btnBck.BackgroundImage = global::Coromandel.Properties.Resources.Login;
            this.btnBck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBck.FlatAppearance.BorderSize = 0;
            this.btnBck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBck.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnBck.ForeColor = System.Drawing.Color.Black;
            this.btnBck.Location = new System.Drawing.Point(925, 740);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(150, 53);
            this.btnBck.TabIndex = 6;
            this.btnBck.Text = "BACK";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.button1_Click);
            // 
            // Language_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1278, 1001);
            this.ControlBox = false;
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.btnTelugu);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnEnglish);
            this.Name = "Language_Selection";
            this.Text = "Language Selection";
            this.Controls.SetChildIndex(this.btnEnglish, 0);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.btnTelugu, 0);
            this.Controls.SetChildIndex(this.btnBck, 0);
            ((System.ComponentModel.ISupportInitialize)(this.activityMonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnTelugu;
        private System.Windows.Forms.Button btnBck;
        public System.Windows.Forms.BindingSource activityMonitorBindingSource;

    }
}
