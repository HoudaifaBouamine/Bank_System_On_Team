namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHistorique
{
    partial class frm_TransactionDetailles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TransactionDetailles));
            this.lbl_TransactionType = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_SenderAccNum = new System.Windows.Forms.Label();
            this.lbl_SenderName = new System.Windows.Forms.Label();
            this.lbl_ReceiverAccNum = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_ReceiverName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TransactionType
            // 
            this.lbl_TransactionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.lbl_TransactionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TransactionType.Font = new System.Drawing.Font("Arial", 24.8F);
            this.lbl_TransactionType.ForeColor = System.Drawing.Color.White;
            this.lbl_TransactionType.Location = new System.Drawing.Point(0, 0);
            this.lbl_TransactionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TransactionType.Name = "lbl_TransactionType";
            this.lbl_TransactionType.Size = new System.Drawing.Size(481, 111);
            this.lbl_TransactionType.TabIndex = 0;
            this.lbl_TransactionType.Text = "Transfer";
            this.lbl_TransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ID.Location = new System.Drawing.Point(0, 111);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(481, 63);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Transaction ID : 1";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ID.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_ID.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_ID.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lbl_SenderAccNum
            // 
            this.lbl_SenderAccNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_SenderAccNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_SenderAccNum.Location = new System.Drawing.Point(0, 174);
            this.lbl_SenderAccNum.Name = "lbl_SenderAccNum";
            this.lbl_SenderAccNum.Size = new System.Drawing.Size(481, 63);
            this.lbl_SenderAccNum.TabIndex = 2;
            this.lbl_SenderAccNum.Text = "Sender Account Number : 1017";
            this.lbl_SenderAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SenderAccNum.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_SenderAccNum.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_SenderAccNum.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lbl_SenderName
            // 
            this.lbl_SenderName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_SenderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_SenderName.Location = new System.Drawing.Point(0, 237);
            this.lbl_SenderName.Name = "lbl_SenderName";
            this.lbl_SenderName.Size = new System.Drawing.Size(481, 63);
            this.lbl_SenderName.TabIndex = 5;
            this.lbl_SenderName.Text = "Sender Name : Houdaifa Bouamine";
            this.lbl_SenderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SenderName.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_SenderName.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_SenderName.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lbl_ReceiverAccNum
            // 
            this.lbl_ReceiverAccNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ReceiverAccNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ReceiverAccNum.Location = new System.Drawing.Point(0, 300);
            this.lbl_ReceiverAccNum.Name = "lbl_ReceiverAccNum";
            this.lbl_ReceiverAccNum.Size = new System.Drawing.Size(481, 63);
            this.lbl_ReceiverAccNum.TabIndex = 6;
            this.lbl_ReceiverAccNum.Text = "Receiver Account Number : 1018";
            this.lbl_ReceiverAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ReceiverAccNum.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_ReceiverAccNum.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_ReceiverAccNum.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_DateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_DateTime.Location = new System.Drawing.Point(0, 489);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(481, 63);
            this.lbl_DateTime.TabIndex = 11;
            this.lbl_DateTime.Text = "Date Time : 12/15/2022 10:00";
            this.lbl_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DateTime.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_DateTime.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_DateTime.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Amount.Location = new System.Drawing.Point(0, 426);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(481, 63);
            this.lbl_Amount.TabIndex = 10;
            this.lbl_Amount.Text = "Amount : 199.99 $";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Amount.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_Amount.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_Amount.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lbl_ReceiverName
            // 
            this.lbl_ReceiverName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ReceiverName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ReceiverName.Location = new System.Drawing.Point(0, 363);
            this.lbl_ReceiverName.Name = "lbl_ReceiverName";
            this.lbl_ReceiverName.Size = new System.Drawing.Size(481, 63);
            this.lbl_ReceiverName.TabIndex = 9;
            this.lbl_ReceiverName.Text = "Receiver Name : Mohamed Riad";
            this.lbl_ReceiverName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ReceiverName.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_ReceiverName.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbl_ReceiverName.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // frm_TransactionDetailles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(481, 555);
            this.Controls.Add(this.lbl_DateTime);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_ReceiverName);
            this.Controls.Add(this.lbl_ReceiverAccNum);
            this.Controls.Add(this.lbl_SenderName);
            this.Controls.Add(this.lbl_SenderAccNum);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_TransactionType);
            this.Font = new System.Drawing.Font("Arial", 12.8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_TransactionDetailles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionDetailles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TransactionType;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_SenderAccNum;
        private System.Windows.Forms.Label lbl_SenderName;
        private System.Windows.Forms.Label lbl_ReceiverAccNum;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_ReceiverName;
    }
}