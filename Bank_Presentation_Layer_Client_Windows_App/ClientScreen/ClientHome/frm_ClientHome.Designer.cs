namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    partial class frm_ClientHome
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
            this.pnl_Balance = new System.Windows.Forms.Panel();
            this.pnl_Deposit = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.pnl_Transfer = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.pnl_Withdraw = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Deposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl_Transfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnl_Withdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Balance
            // 
            this.pnl_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Balance.Location = new System.Drawing.Point(40, 40);
            this.pnl_Balance.Name = "pnl_Balance";
            this.pnl_Balance.Size = new System.Drawing.Size(850, 232);
            this.pnl_Balance.TabIndex = 9;
            // 
            // pnl_Deposit
            // 
            this.pnl_Deposit.BackColor = System.Drawing.Color.White;
            this.pnl_Deposit.Controls.Add(this.btn_Deposit);
            this.pnl_Deposit.Controls.Add(this.pictureBox4);
            this.pnl_Deposit.Location = new System.Drawing.Point(0, 0);
            this.pnl_Deposit.Name = "pnl_Deposit";
            this.pnl_Deposit.Size = new System.Drawing.Size(261, 335);
            this.pnl_Deposit.TabIndex = 20;
            this.pnl_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = global::Bank_Presentation_Layer_Windows_App.Properties.Resources.img_Deposit_Withdraw;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(13, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(234, 200);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Deposit.FlatAppearance.BorderSize = 0;
            this.btn_Deposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Deposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deposit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Deposit.ForeColor = System.Drawing.Color.White;
            this.btn_Deposit.Location = new System.Drawing.Point(13, 234);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(234, 44);
            this.btn_Deposit.TabIndex = 5;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = false;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // pnl_Transfer
            // 
            this.pnl_Transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Transfer.BackColor = System.Drawing.Color.White;
            this.pnl_Transfer.Controls.Add(this.btn_Transfer);
            this.pnl_Transfer.Controls.Add(this.pictureBox5);
            this.pnl_Transfer.Location = new System.Drawing.Point(589, 0);
            this.pnl_Transfer.Name = "pnl_Transfer";
            this.pnl_Transfer.Size = new System.Drawing.Size(261, 335);
            this.pnl_Transfer.TabIndex = 30;
            this.pnl_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackgroundImage = global::Bank_Presentation_Layer_Windows_App.Properties.Resources.img_Transfer;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(13, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(234, 200);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Transfer.FlatAppearance.BorderSize = 0;
            this.btn_Transfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Transfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transfer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Transfer.ForeColor = System.Drawing.Color.White;
            this.btn_Transfer.Location = new System.Drawing.Point(13, 234);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(234, 44);
            this.btn_Transfer.TabIndex = 5;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = false;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // pnl_Withdraw
            // 
            this.pnl_Withdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_Withdraw.BackColor = System.Drawing.Color.White;
            this.pnl_Withdraw.Controls.Add(this.btn_Withdraw);
            this.pnl_Withdraw.Controls.Add(this.pictureBox2);
            this.pnl_Withdraw.Location = new System.Drawing.Point(292, 0);
            this.pnl_Withdraw.Name = "pnl_Withdraw";
            this.pnl_Withdraw.Size = new System.Drawing.Size(261, 335);
            this.pnl_Withdraw.TabIndex = 27;
            this.pnl_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::Bank_Presentation_Layer_Windows_App.Properties.Resources.img_Deposit_Withdraw;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(13, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Withdraw.FlatAppearance.BorderSize = 0;
            this.btn_Withdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Withdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Withdraw.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Withdraw.ForeColor = System.Drawing.Color.White;
            this.btn_Withdraw.Location = new System.Drawing.Point(13, 234);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(234, 44);
            this.btn_Withdraw.TabIndex = 5;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = false;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Main.Controls.Add(this.pnl_Withdraw);
            this.pnl_Main.Controls.Add(this.pnl_Transfer);
            this.pnl_Main.Controls.Add(this.pnl_Deposit);
            this.pnl_Main.Location = new System.Drawing.Point(40, 311);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(850, 409);
            this.pnl_Main.TabIndex = 13;
            // 
            // frm_ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(930, 720);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Balance);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ClientHome";
            this.Text = "frm_ClientHomePage";
            this.Load += new System.EventHandler(this.frm_ClientHome_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_ClientHome_Paint);
            this.pnl_Deposit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl_Transfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnl_Withdraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Balance;
        private System.Windows.Forms.Panel pnl_Deposit;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnl_Transfer;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnl_Withdraw;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnl_Main;
    }
}