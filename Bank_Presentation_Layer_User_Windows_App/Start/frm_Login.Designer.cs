namespace Bank_Presentation_Layer_User_Windows_App.Start
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            panel1 = new Panel();
            btn_Login = new Button();
            label3 = new Label();
            tb_Password = new TextBox();
            label2 = new Label();
            tb_Email = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 255, 255, 255);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_Password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_Email);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(657, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 550);
            panel1.TabIndex = 0;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(17, 45, 78);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 81, 111);
            btn_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 62, 94);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(39, 376);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(371, 44);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 253);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.White;
            tb_Password.Font = new Font("Arial", 14.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.Location = new Point(39, 278);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '•';
            tb_Password.Size = new Size(371, 35);
            tb_Password.TabIndex = 3;
            tb_Password.Text = "houdaifa.bouamine@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 141);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.White;
            tb_Email.Font = new Font("Arial", 14.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Email.Location = new Point(39, 166);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(371, 35);
            tb_Email.TabIndex = 1;
            tb_Email.Text = "houdaifa.bouamine@gmail.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 38);
            label1.Name = "label1";
            label1.Size = new Size(109, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            BackgroundImage = Properties.Resources.img_Background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 680);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox tb_Email;
        private Label label3;
        private TextBox tb_Password;
        private Button btn_Login;
    }
}