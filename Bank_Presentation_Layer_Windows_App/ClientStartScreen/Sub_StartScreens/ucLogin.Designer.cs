namespace Bank_Presentation_Layer_Windows_App.ClientStartScreen
{
    partial class ucLogin
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_Dont_Have_Account = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.tb_Pass_Or_PinCode = new System.Windows.Forms.MaskedTextBox();
            this.tb_Email_or_AccNum_or_UserName = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Password_Or_PinCode = new System.Windows.Forms.Label();
            this.lbl_Email_or_AccNum_or_UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Login_Email = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.linkLabel1.Location = new System.Drawing.Point(314, 508);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 19);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_Dont_Have_Account
            // 
            this.lbl_Dont_Have_Account.AutoSize = true;
            this.lbl_Dont_Have_Account.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dont_Have_Account.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Dont_Have_Account.Location = new System.Drawing.Point(107, 508);
            this.lbl_Dont_Have_Account.Name = "lbl_Dont_Have_Account";
            this.lbl_Dont_Have_Account.Size = new System.Drawing.Size(200, 19);
            this.lbl_Dont_Have_Account.TabIndex = 14;
            this.lbl_Dont_Have_Account.Text = "Don\'t have an account ?";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(49, 440);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(401, 44);
            this.btn_SignUp.TabIndex = 12;
            this.btn_SignUp.Text = "Log In";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // tb_Pass_Or_PinCode
            // 
            this.tb_Pass_Or_PinCode.AsciiOnly = true;
            this.tb_Pass_Or_PinCode.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Pass_Or_PinCode.Font = new System.Drawing.Font("Arial", 14F);
            this.tb_Pass_Or_PinCode.Location = new System.Drawing.Point(49, 353);
            this.tb_Pass_Or_PinCode.Name = "tb_Pass_Or_PinCode";
            this.tb_Pass_Or_PinCode.PasswordChar = '•';
            this.tb_Pass_Or_PinCode.Size = new System.Drawing.Size(403, 34);
            this.tb_Pass_Or_PinCode.TabIndex = 10;
            // 
            // tb_Email_or_AccNum_or_UserName
            // 
            this.tb_Email_or_AccNum_or_UserName.AsciiOnly = true;
            this.tb_Email_or_AccNum_or_UserName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Email_or_AccNum_or_UserName.Font = new System.Drawing.Font("Arial", 14F);
            this.tb_Email_or_AccNum_or_UserName.Location = new System.Drawing.Point(49, 232);
            this.tb_Email_or_AccNum_or_UserName.Name = "tb_Email_or_AccNum_or_UserName";
            this.tb_Email_or_AccNum_or_UserName.Size = new System.Drawing.Size(401, 34);
            this.tb_Email_or_AccNum_or_UserName.TabIndex = 6;
            // 
            // lbl_Password_Or_PinCode
            // 
            this.lbl_Password_Or_PinCode.AutoSize = true;
            this.lbl_Password_Or_PinCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password_Or_PinCode.Font = new System.Drawing.Font("Arial", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_Or_PinCode.Location = new System.Drawing.Point(45, 328);
            this.lbl_Password_Or_PinCode.Name = "lbl_Password_Or_PinCode";
            this.lbl_Password_Or_PinCode.Size = new System.Drawing.Size(89, 22);
            this.lbl_Password_Or_PinCode.TabIndex = 13;
            this.lbl_Password_Or_PinCode.Text = "Pin Code\r\n";
            // 
            // lbl_Email_or_AccNum_or_UserName
            // 
            this.lbl_Email_or_AccNum_or_UserName.AutoSize = true;
            this.lbl_Email_or_AccNum_or_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email_or_AccNum_or_UserName.Font = new System.Drawing.Font("Arial", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_or_AccNum_or_UserName.Location = new System.Drawing.Point(45, 207);
            this.lbl_Email_or_AccNum_or_UserName.Name = "lbl_Email_or_AccNum_or_UserName";
            this.lbl_Email_or_AccNum_or_UserName.Size = new System.Drawing.Size(151, 22);
            this.lbl_Email_or_AccNum_or_UserName.TabIndex = 9;
            this.lbl_Email_or_AccNum_or_UserName.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // cb_Login_Email
            // 
            this.cb_Login_Email.AutoSize = true;
            this.cb_Login_Email.BackColor = System.Drawing.Color.Transparent;
            this.cb_Login_Email.Location = new System.Drawing.Point(49, 272);
            this.cb_Login_Email.Name = "cb_Login_Email";
            this.cb_Login_Email.Size = new System.Drawing.Size(147, 23);
            this.cb_Login_Email.TabIndex = 17;
            this.cb_Login_Email.Text = "Login with email";
            this.cb_Login_Email.UseVisualStyleBackColor = false;
            this.cb_Login_Email.CheckedChanged += new System.EventHandler(this.cb_Login_Email_CheckedChanged);
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.cb_Login_Email);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_Dont_Have_Account);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.tb_Pass_Or_PinCode);
            this.Controls.Add(this.tb_Email_or_AccNum_or_UserName);
            this.Controls.Add(this.lbl_Password_Or_PinCode);
            this.Controls.Add(this.lbl_Email_or_AccNum_or_UserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(500, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_Dont_Have_Account;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.MaskedTextBox tb_Pass_Or_PinCode;
        private System.Windows.Forms.MaskedTextBox tb_Email_or_AccNum_or_UserName;
        private System.Windows.Forms.Label lbl_Password_Or_PinCode;
        private System.Windows.Forms.Label lbl_Email_or_AccNum_or_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Login_Email;
    }
}
