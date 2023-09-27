namespace Bank_Presentation_Layer_Windows_App.ClientStartScreen.Sub_StartScreens
{
    partial class ucVerifyEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnk_ResendKey = new System.Windows.Forms.LinkLabel();
            this.btn_VerifyEmail = new System.Windows.Forms.Button();
            this.tb_VerificationKey = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnk_ResendKey
            // 
            this.lnk_ResendKey.AutoSize = true;
            this.lnk_ResendKey.BackColor = System.Drawing.Color.Transparent;
            this.lnk_ResendKey.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnk_ResendKey.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.lnk_ResendKey.Location = new System.Drawing.Point(45, 337);
            this.lnk_ResendKey.Name = "lnk_ResendKey";
            this.lnk_ResendKey.Size = new System.Drawing.Size(98, 19);
            this.lnk_ResendKey.TabIndex = 17;
            this.lnk_ResendKey.TabStop = true;
            this.lnk_ResendKey.Text = "Resend Key";
            this.lnk_ResendKey.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            // 
            // btn_VerifyEmail
            // 
            this.btn_VerifyEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_VerifyEmail.FlatAppearance.BorderSize = 0;
            this.btn_VerifyEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_VerifyEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_VerifyEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerifyEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_VerifyEmail.ForeColor = System.Drawing.Color.White;
            this.btn_VerifyEmail.Location = new System.Drawing.Point(49, 280);
            this.btn_VerifyEmail.Name = "btn_VerifyEmail";
            this.btn_VerifyEmail.Size = new System.Drawing.Size(401, 44);
            this.btn_VerifyEmail.TabIndex = 16;
            this.btn_VerifyEmail.Text = "Verify Email";
            this.btn_VerifyEmail.UseVisualStyleBackColor = false;
            this.btn_VerifyEmail.Click += new System.EventHandler(this.btn_VerifyEmail_Click);
            // 
            // tb_VerificationKey
            // 
            this.tb_VerificationKey.AsciiOnly = true;
            this.tb_VerificationKey.BackColor = System.Drawing.SystemColors.Window;
            this.tb_VerificationKey.Font = new System.Drawing.Font("Arial", 14F);
            this.tb_VerificationKey.Location = new System.Drawing.Point(49, 195);
            this.tb_VerificationKey.Name = "tb_VerificationKey";
            this.tb_VerificationKey.Size = new System.Drawing.Size(401, 34);
            this.tb_VerificationKey.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Verification Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email Verification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.2F);
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Please enter the 6 digit received number";
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.label4);
            this.pnl_Main.Controls.Add(this.lnk_ResendKey);
            this.pnl_Main.Controls.Add(this.tb_VerificationKey);
            this.pnl_Main.Controls.Add(this.btn_VerifyEmail);
            this.pnl_Main.Location = new System.Drawing.Point(0, 119);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(500, 407);
            this.pnl_Main.TabIndex = 19;
            // 
            // ucVerifyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucVerifyEmail";
            this.Size = new System.Drawing.Size(500, 650);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_ResendKey;
        private System.Windows.Forms.Button btn_VerifyEmail;
        private System.Windows.Forms.MaskedTextBox tb_VerificationKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Main;
    }
}
