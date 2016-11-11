namespace Coromandel
{
    partial class Change_password
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtCnfrmCp = new System.Windows.Forms.TextBox();
            this.txnewCp = new System.Windows.Forms.TextBox();
            this.lblCb = new System.Windows.Forms.Label();
            this.lblLr = new System.Windows.Forms.Label();
            this.lblOb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Image = global::Coromandel.Properties.Resources.Login;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(588, 500);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 53);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Window;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::Coromandel.Properties.Resources.Login;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(935, 695);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 53);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(552, 480);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 42;
            this.lblerror.Visible = false;
            // 
            // txtCp
            // 
            this.txtCp.AllowDrop = true;
            this.txtCp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCp.Location = new System.Drawing.Point(658, 316);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(170, 20);
            this.txtCp.TabIndex = 3;
            // 
            // txtCnfrmCp
            // 
            this.txtCnfrmCp.Location = new System.Drawing.Point(658, 418);
            this.txtCnfrmCp.Name = "txtCnfrmCp";
            this.txtCnfrmCp.PasswordChar = '*';
            this.txtCnfrmCp.Size = new System.Drawing.Size(170, 20);
            this.txtCnfrmCp.TabIndex = 5;
            // 
            // txnewCp
            // 
            this.txnewCp.Location = new System.Drawing.Point(658, 365);
            this.txnewCp.Name = "txnewCp";
            this.txnewCp.PasswordChar = '*';
            this.txnewCp.Size = new System.Drawing.Size(170, 20);
            this.txnewCp.TabIndex = 4;
            // 
            // lblCb
            // 
            this.lblCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCb.AutoSize = true;
            this.lblCb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCb.ForeColor = System.Drawing.Color.Black;
            this.lblCb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCb.Location = new System.Drawing.Point(432, 316);
            this.lblCb.Name = "lblCb";
            this.lblCb.Size = new System.Drawing.Size(197, 16);
            this.lblCb.TabIndex = 2;
            this.lblCb.Text = "CONFIRM NEW PASSWORD";
            // 
            // lblLr
            // 
            this.lblLr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLr.AutoSize = true;
            this.lblLr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLr.ForeColor = System.Drawing.Color.Black;
            this.lblLr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLr.Location = new System.Drawing.Point(503, 263);
            this.lblLr.Name = "lblLr";
            this.lblLr.Size = new System.Drawing.Size(126, 16);
            this.lblLr.TabIndex = 1;
            this.lblLr.Text = "NEW PASSWORD";
            // 
            // lblOb
            // 
            this.lblOb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOb.AutoSize = true;
            this.lblOb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOb.ForeColor = System.Drawing.Color.Black;
            this.lblOb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOb.Location = new System.Drawing.Point(471, 214);
            this.lblOb.Name = "lblOb";
            this.lblOb.Size = new System.Drawing.Size(158, 16);
            this.lblOb.TabIndex = 0;
            this.lblOb.Text = "CURRENT PASSWORD";
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1270, 788);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txtCnfrmCp);
            this.Controls.Add(this.lblCb);
            this.Controls.Add(this.txnewCp);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.lblOb);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLr);
            this.Name = "Change_password";
            this.Load += new System.EventHandler(this.Change_password_Load);
            this.Controls.SetChildIndex(this.lblLr, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.lblOb, 0);
            this.Controls.SetChildIndex(this.txtCp, 0);
            this.Controls.SetChildIndex(this.txnewCp, 0);
            this.Controls.SetChildIndex(this.lblCb, 0);
            this.Controls.SetChildIndex(this.txtCnfrmCp, 0);
            this.Controls.SetChildIndex(this.lblerror, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtCnfrmCp;
        private System.Windows.Forms.TextBox txnewCp;
        private System.Windows.Forms.Label lblCb;
        private System.Windows.Forms.Label lblLr;
        private System.Windows.Forms.Label lblOb;
    }
}
