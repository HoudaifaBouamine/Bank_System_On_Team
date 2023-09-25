﻿namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer
{
    partial class frm_TransferMainScreen
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
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_AccountNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Amount
            // 
            this.tb_Amount.BackColor = System.Drawing.Color.White;
            this.tb_Amount.Font = new System.Drawing.Font("Arial", 12.2F);
            this.tb_Amount.ForeColor = System.Drawing.Color.Black;
            this.tb_Amount.Location = new System.Drawing.Point(96, 300);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(758, 31);
            this.tb_Amount.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.2F);
            this.label9.Location = new System.Drawing.Point(91, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 27);
            this.label9.TabIndex = 46;
            this.label9.Text = "Amount";
            // 
            // tb_AccountNumber
            // 
            this.tb_AccountNumber.BackColor = System.Drawing.Color.White;
            this.tb_AccountNumber.Font = new System.Drawing.Font("Arial", 12.2F);
            this.tb_AccountNumber.ForeColor = System.Drawing.Color.Black;
            this.tb_AccountNumber.Location = new System.Drawing.Point(96, 193);
            this.tb_AccountNumber.Name = "tb_AccountNumber";
            this.tb_AccountNumber.Size = new System.Drawing.Size(758, 31);
            this.tb_AccountNumber.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.2F);
            this.label7.Location = new System.Drawing.Point(91, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 27);
            this.label7.TabIndex = 45;
            this.label7.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(61, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 37);
            this.label8.TabIndex = 47;
            this.label8.Text = "Transfer";
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.Font = new System.Drawing.Font("Arial", 12.2F);
            this.tb_Password.ForeColor = System.Drawing.Color.Black;
            this.tb_Password.Location = new System.Drawing.Point(96, 407);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(758, 31);
            this.tb_Password.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.2F);
            this.label1.Location = new System.Drawing.Point(91, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "Password";
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(96, 474);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(758, 44);
            this.btn_Next.TabIndex = 51;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // frm_TransferMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(930, 720);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_AccountNumber);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_TransferMainScreen";
            this.Text = "frm_TransferMainScreen";
            this.Load += new System.EventHandler(this.frm_TransferMainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_AccountNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Next;
    }
}