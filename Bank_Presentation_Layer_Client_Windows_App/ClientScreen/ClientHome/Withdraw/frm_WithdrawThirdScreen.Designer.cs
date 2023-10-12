namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw
{
    partial class frm_WithdrawThirdScreen
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_SenderAccountNumber = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TransferStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(124)))), ((int)(((byte)(175)))));
            this.panel5.Controls.Add(this.lbl_Amount);
            this.panel5.Controls.Add(this.lbl_SenderAccountNumber);
            this.panel5.Controls.Add(this.lbl_DateTime);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbl_TransferStatus);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(100, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 370);
            this.panel5.TabIndex = 14;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Amount.Font = new System.Drawing.Font("Arial", 33.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Amount.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amount.Location = new System.Drawing.Point(363, 192);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(314, 70);
            this.lbl_Amount.TabIndex = 8;
            this.lbl_Amount.Text = "100.00  $";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SenderAccountNumber
            // 
            this.lbl_SenderAccountNumber.AutoSize = true;
            this.lbl_SenderAccountNumber.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbl_SenderAccountNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_SenderAccountNumber.Location = new System.Drawing.Point(214, 86);
            this.lbl_SenderAccountNumber.Name = "lbl_SenderAccountNumber";
            this.lbl_SenderAccountNumber.Size = new System.Drawing.Size(76, 26);
            this.lbl_SenderAccountNumber.TabIndex = 7;
            this.lbl_SenderAccountNumber.Text = "B1900";
            this.lbl_SenderAccountNumber.Click += new System.EventHandler(this.lbl_ReceiverAccountNumber_Click);
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(123, 274);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(67, 26);
            this.lbl_DateTime.TabIndex = 5;
            this.lbl_DateTime.Text = "00:00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Withdrowed From : ";
            // 
            // lbl_TransferStatus
            // 
            this.lbl_TransferStatus.AutoSize = true;
            this.lbl_TransferStatus.Font = new System.Drawing.Font("Arial", 13.2F);
            this.lbl_TransferStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(56)))));
            this.lbl_TransferStatus.Location = new System.Drawing.Point(130, 47);
            this.lbl_TransferStatus.Name = "lbl_TransferStatus";
            this.lbl_TransferStatus.Size = new System.Drawing.Size(94, 25);
            this.lbl_TransferStatus.TabIndex = 1;
            this.lbl_TransferStatus.Text = "Success";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status : ";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(100, 489);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 231);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 119);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 720);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(830, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 720);
            this.panel1.TabIndex = 10;
            // 
            // frm_WithdrawThirdScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(930, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_WithdrawThirdScreen";
            this.Text = "frm_WithdrawSecondScreen";
            this.Load += new System.EventHandler(this.frm_WithdrawSecondScreen_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_SenderAccountNumber;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TransferStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}