namespace Coromandel
{
    partial class Welcome_Screen
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
            this.lblHdng = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHdng
            // 
            this.lblHdng.AutoSize = true;
            this.lblHdng.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdng.ForeColor = System.Drawing.Color.Black;
            this.lblHdng.Location = new System.Drawing.Point(286, 349);
            this.lblHdng.Name = "lblHdng";
            this.lblHdng.Size = new System.Drawing.Size(694, 46);
            this.lblHdng.TabIndex = 3;
            this.lblHdng.Text = "COROMANDEL INTERNATIONAL LIMITED";
            // 
            // btnClick
            // 
            this.btnClick.BackgroundImage = global::Coromandel.Properties.Resources.Start;
            this.btnClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClick.FlatAppearance.BorderSize = 0;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(612, 421);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(120, 114);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "START";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(408, 255);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(463, 46);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "WELCOME TO ATI SYSTEM";
            // 
            // Welcome_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1278, 1001);
            this.ControlBox = false;
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblHdng);
            this.Controls.Add(this.lblHeading);
            this.Name = "Welcome_Screen";
            this.Opacity = 0.8D;
            this.Text = "Welcome_Screen";
            this.Load += new System.EventHandler(this.Welcome_Screen_Load);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblHdng, 0);
            this.Controls.SetChildIndex(this.btnClick, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHdng;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblHeading;
    }
}
