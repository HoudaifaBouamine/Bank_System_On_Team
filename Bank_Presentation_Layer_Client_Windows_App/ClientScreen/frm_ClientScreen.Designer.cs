namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    partial class frm_ClientScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ClientScreen));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_Seperator2 = new System.Windows.Forms.Panel();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Historique = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnl_Seperator1 = new System.Windows.Forms.Panel();
            this.pnl_Profile = new System.Windows.Forms.Panel();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.lbl_ClientFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_Start_Refreaching_Client_Info = new System.Windows.Forms.Timer(this.components);
            this.pnl_Menu.SuspendLayout();
            this.pnl_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.pnl_Main.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Main.Location = new System.Drawing.Point(394, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Main.Size = new System.Drawing.Size(1046, 855);
            this.pnl_Main.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.pnl_Seperator2);
            this.pnl_Menu.Controls.Add(this.btn_Settings);
            this.pnl_Menu.Controls.Add(this.btn_Historique);
            this.pnl_Menu.Controls.Add(this.btn_Home);
            this.pnl_Menu.Controls.Add(this.pnl_Seperator1);
            this.pnl_Menu.Controls.Add(this.pnl_Profile);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(394, 855);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(67)))), ((int)(((byte)(115)))));
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(0, 549);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(394, 96);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnl_Seperator2
            // 
            this.pnl_Seperator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Seperator2.Location = new System.Drawing.Point(0, 505);
            this.pnl_Seperator2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Seperator2.Name = "pnl_Seperator2";
            this.pnl_Seperator2.Size = new System.Drawing.Size(394, 44);
            this.pnl_Seperator2.TabIndex = 7;
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(67)))), ((int)(((byte)(115)))));
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Location = new System.Drawing.Point(0, 409);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btn_Settings.Size = new System.Drawing.Size(394, 96);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click_1);
            // 
            // btn_Historique
            // 
            this.btn_Historique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Historique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Historique.FlatAppearance.BorderSize = 0;
            this.btn_Historique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(67)))), ((int)(((byte)(125)))));
            this.btn_Historique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.btn_Historique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historique.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historique.ForeColor = System.Drawing.Color.White;
            this.btn_Historique.Location = new System.Drawing.Point(0, 313);
            this.btn_Historique.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Historique.Name = "btn_Historique";
            this.btn_Historique.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btn_Historique.Size = new System.Drawing.Size(394, 96);
            this.btn_Historique.TabIndex = 5;
            this.btn_Historique.Text = "Historique";
            this.btn_Historique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Historique.UseVisualStyleBackColor = false;
            this.btn_Historique.Click += new System.EventHandler(this.btn_Historique_Click_1);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(67)))), ((int)(((byte)(115)))));
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(0, 217);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(394, 96);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click_1);
            // 
            // pnl_Seperator1
            // 
            this.pnl_Seperator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Seperator1.Location = new System.Drawing.Point(0, 173);
            this.pnl_Seperator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Seperator1.Name = "pnl_Seperator1";
            this.pnl_Seperator1.Size = new System.Drawing.Size(394, 44);
            this.pnl_Seperator1.TabIndex = 1;
            // 
            // pnl_Profile
            // 
            this.pnl_Profile.Controls.Add(this.lbl_UserType);
            this.pnl_Profile.Controls.Add(this.lbl_ClientFullName);
            this.pnl_Profile.Controls.Add(this.pictureBox1);
            this.pnl_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Profile.Location = new System.Drawing.Point(0, 0);
            this.pnl_Profile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Profile.Name = "pnl_Profile";
            this.pnl_Profile.Size = new System.Drawing.Size(394, 173);
            this.pnl_Profile.TabIndex = 0;
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Font = new System.Drawing.Font("Arial", 7.2F);
            this.lbl_UserType.ForeColor = System.Drawing.Color.White;
            this.lbl_UserType.Location = new System.Drawing.Point(150, 104);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(83, 15);
            this.lbl_UserType.TabIndex = 1;
            this.lbl_UserType.Text = "Normal Client";
            // 
            // lbl_ClientFullName
            // 
            this.lbl_ClientFullName.AutoSize = true;
            this.lbl_ClientFullName.Font = new System.Drawing.Font("Arial", 11.2F);
            this.lbl_ClientFullName.ForeColor = System.Drawing.Color.White;
            this.lbl_ClientFullName.Location = new System.Drawing.Point(148, 68);
            this.lbl_ClientFullName.Name = "lbl_ClientFullName";
            this.lbl_ClientFullName.Size = new System.Drawing.Size(175, 22);
            this.lbl_ClientFullName.TabIndex = 1;
            this.lbl_ClientFullName.Text = "Houdaifa Bouamine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(39, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer_Start_Refreaching_Client_Info
            // 
            this.timer_Start_Refreaching_Client_Info.Interval = 1000;
            this.timer_Start_Refreaching_Client_Info.Tick += new System.EventHandler(this.timer_Start_Refreaching_Client_Info_Tick);
            // 
            // frm_ClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1440, 855);
            this.Controls.Add(this.pnl_Menu);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frm_ClientScreen";
            this.Text = "frm_ClientScreen";
            this.Load += new System.EventHandler(this.frm_ClientScreen_Load);
            this.Controls.SetChildIndex(this.pnl_Menu, 0);
            this.Controls.SetChildIndex(this.pnl_Main, 0);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Profile.ResumeLayout(false);
            this.pnl_Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_ClientFullName;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.Panel pnl_Seperator2;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Historique;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel pnl_Seperator1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Timer timer_Start_Refreaching_Client_Info;
    }
}