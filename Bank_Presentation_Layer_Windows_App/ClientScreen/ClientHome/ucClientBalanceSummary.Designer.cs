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
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_LastTransaction = new System.Windows.Forms.Panel();
            this.zeroitBevelLine1 = new Zeroit.Framework.LineSeparators.ZeroitBevelLine();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.lbl_TimeTitle = new System.Windows.Forms.Label();
            this.lbl_TransactionType = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_LastTransAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // pnl_LastTransaction
            // 
            this.pnl_LastTransaction.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LastTransaction.Controls.Add(this.zeroitBevelLine1);
            this.pnl_LastTransaction.Controls.Add(this.lbl_DateTime);
            this.pnl_LastTransaction.Controls.Add(this.lbl_TimeTitle);
            this.pnl_LastTransaction.Controls.Add(this.lbl_TransactionType);
            this.pnl_LastTransaction.Controls.Add(this.lbl_Title);
            this.pnl_LastTransaction.Controls.Add(this.lbl_LastTransAmount);
            this.pnl_LastTransaction.Controls.Add(this.panel1);
            this.pnl_LastTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_LastTransaction.Location = new System.Drawing.Point(272, 0);
            this.pnl_LastTransaction.Name = "pnl_LastTransaction";
            this.pnl_LastTransaction.Size = new System.Drawing.Size(589, 232);
            this.pnl_LastTransaction.TabIndex = 2;
            this.pnl_LastTransaction.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_LastTransaction_Paint);
            // 
            // zeroitBevelLine1
            // 
            this.zeroitBevelLine1.AllowTransparency = true;
            this.zeroitBevelLine1.Angle = 0;
            this.zeroitBevelLine1.BackColor = System.Drawing.Color.White;
            this.zeroitBevelLine1.Blend = true;
            this.zeroitBevelLine1.Location = new System.Drawing.Point(3, 27);
            this.zeroitBevelLine1.Name = "zeroitBevelLine1";
            this.zeroitBevelLine1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zeroitBevelLine1.Size = new System.Drawing.Size(2, 180);
            this.zeroitBevelLine1.TabIndex = 9;
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
            // lbl_TimeTitle
            // 
            this.lbl_TimeTitle.AutoSize = true;
            this.lbl_TimeTitle.Font = new System.Drawing.Font("Arial", 9.8F);
            this.lbl_TimeTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_TimeTitle.Location = new System.Drawing.Point(55, 176);
            this.lbl_TimeTitle.Name = "lbl_TimeTitle";
            this.lbl_TimeTitle.Size = new System.Drawing.Size(58, 19);
            this.lbl_TimeTitle.TabIndex = 4;
            this.lbl_TimeTitle.Text = "Time : ";
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
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(53, 51);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(124, 33);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Recents";
            // 
            // lbl_LastTransAmount
            // 
            this.lbl_LastTransAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LastTransAmount.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold);
            this.lbl_LastTransAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(56)))));
            this.lbl_LastTransAmount.Location = new System.Drawing.Point(0, 0);
            this.lbl_LastTransAmount.Name = "lbl_LastTransAmount";
            this.lbl_LastTransAmount.Size = new System.Drawing.Size(531, 232);
            this.lbl_LastTransAmount.TabIndex = 8;
            this.lbl_LastTransAmount.Text = "+10.00 $";
            this.lbl_LastTransAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_LastTransAmount.Click += new System.EventHandler(this.lbl_LastTransAmount_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(531, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 232);
            this.panel1.TabIndex = 7;
            // 
            // ucClientBalanceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.pnl_LastTransaction);
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
        private System.Windows.Forms.Panel pnl_LastTransaction;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_Title;
        public System.Windows.Forms.Label lbl_TransactionType;
        public System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label lbl_TimeTitle;
        public System.Windows.Forms.Label lbl_LastTransAmount;
        private System.Windows.Forms.Panel panel1;
        private Zeroit.Framework.LineSeparators.ZeroitBevelLine zeroitBevelLine1;
    }
}
