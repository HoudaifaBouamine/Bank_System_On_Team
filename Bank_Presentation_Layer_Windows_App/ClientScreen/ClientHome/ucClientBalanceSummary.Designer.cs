namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome
{
    partial class ucClientBalanceSummary
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
            this.pnl_Balance = new System.Windows.Forms.Panel();
            this.pnl_Seperator = new System.Windows.Forms.Panel();
            this.pnl_LastTransaction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TransactionType = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_LastTransAmount = new System.Windows.Forms.Label();
            this.pnl_Balance.SuspendLayout();
            this.pnl_LastTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Balance
            // 
            this.pnl_Balance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Balance.Controls.Add(this.lbl_Balance);
            this.pnl_Balance.Controls.Add(this.label1);
            this.pnl_Balance.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Balance.Location = new System.Drawing.Point(0, 0);
            this.pnl_Balance.Name = "pnl_Balance";
            this.pnl_Balance.Size = new System.Drawing.Size(272, 232);
            this.pnl_Balance.TabIndex = 0;
            // 
            // pnl_Seperator
            // 
            this.pnl_Seperator.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Seperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Seperator.Location = new System.Drawing.Point(272, 0);
            this.pnl_Seperator.Name = "pnl_Seperator";
            this.pnl_Seperator.Size = new System.Drawing.Size(21, 232);
            this.pnl_Seperator.TabIndex = 1;
            // 
            // pnl_LastTransaction
            // 
            this.pnl_LastTransaction.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LastTransaction.Controls.Add(this.lbl_LastTransAmount);
            this.pnl_LastTransaction.Controls.Add(this.label3);
            this.pnl_LastTransaction.Controls.Add(this.lbl_DateTime);
            this.pnl_LastTransaction.Controls.Add(this.lbl_TransactionType);
            this.pnl_LastTransaction.Controls.Add(this.label2);
            this.pnl_LastTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_LastTransaction.Location = new System.Drawing.Point(293, 0);
            this.pnl_LastTransaction.Name = "pnl_LastTransaction";
            this.pnl_LastTransaction.Size = new System.Drawing.Size(568, 232);
            this.pnl_LastTransaction.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Balance.Font = new System.Drawing.Font("Arial", 17.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Balance.ForeColor = System.Drawing.Color.White;
            this.lbl_Balance.Location = new System.Drawing.Point(15, 102);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(238, 62);
            this.lbl_Balance.TabIndex = 1;
            this.lbl_Balance.Text = "150.00 $";
            this.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recents";
            // 
            // lbl_TransactionType
            // 
            this.lbl_TransactionType.AutoSize = true;
            this.lbl_TransactionType.Font = new System.Drawing.Font("Arial", 9.8F);
            this.lbl_TransactionType.ForeColor = System.Drawing.Color.White;
            this.lbl_TransactionType.Location = new System.Drawing.Point(55, 99);
            this.lbl_TransactionType.Name = "lbl_TransactionType";
            this.lbl_TransactionType.Size = new System.Drawing.Size(64, 19);
            this.lbl_TransactionType.TabIndex = 2;
            this.lbl_TransactionType.Text = "Deposit";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Arial", 9.8F);
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(119, 176);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(89, 19);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "00:00 GMT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time : ";
            // 
            // lbl_LastTransAmount
            // 
            this.lbl_LastTransAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_LastTransAmount.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold);
            this.lbl_LastTransAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(56)))));
            this.lbl_LastTransAmount.Location = new System.Drawing.Point(242, 118);
            this.lbl_LastTransAmount.Name = "lbl_LastTransAmount";
            this.lbl_LastTransAmount.Size = new System.Drawing.Size(273, 33);
            this.lbl_LastTransAmount.TabIndex = 5;
            this.lbl_LastTransAmount.Text = "+10.00 $";
            this.lbl_LastTransAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucClientBalanceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.pnl_LastTransaction);
            this.Controls.Add(this.pnl_Seperator);
            this.Controls.Add(this.pnl_Balance);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucClientBalanceSummary";
            this.Size = new System.Drawing.Size(861, 232);
            this.pnl_Balance.ResumeLayout(false);
            this.pnl_Balance.PerformLayout();
            this.pnl_LastTransaction.ResumeLayout(false);
            this.pnl_LastTransaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Balance;
        private System.Windows.Forms.Panel pnl_Seperator;
        private System.Windows.Forms.Panel pnl_LastTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TransactionType;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_LastTransAmount;
    }
}
