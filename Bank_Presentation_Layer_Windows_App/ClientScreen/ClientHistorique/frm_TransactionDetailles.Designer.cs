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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Sender_AccountNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Receiver_AccountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(72, 118);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(165, 22);
            this.tb_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(72, 206);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(165, 22);
            this.tb_Amount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sender ID";
            // 
            // tb_Sender_ID
            // 
            this.tb_Sender_AccountNumber.Location = new System.Drawing.Point(76, 298);
            this.tb_Sender_AccountNumber.Name = "tb_Sender_ID";
            this.tb_Sender_AccountNumber.Size = new System.Drawing.Size(165, 22);
            this.tb_Sender_AccountNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Receiver ID";
            // 
            // tb_Receiver_ID
            // 
            this.tb_Receiver_AccountNumber.Location = new System.Drawing.Point(72, 404);
            this.tb_Receiver_AccountNumber.Name = "tb_Receiver_ID";
            this.tb_Receiver_AccountNumber.Size = new System.Drawing.Size(165, 22);
            this.tb_Receiver_AccountNumber.TabIndex = 6;
            // 
            // TransactionDetailles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Receiver_AccountNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Sender_AccountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ID);
            this.Name = "TransactionDetailles";
            this.Text = "TransactionDetailles";
            this.Load += new System.EventHandler(this.TransactionDetailles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Sender_AccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Receiver_AccountNumber;
    }
}