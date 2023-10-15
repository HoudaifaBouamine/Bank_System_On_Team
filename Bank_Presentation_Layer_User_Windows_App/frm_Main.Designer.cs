namespace Bank_Presentation_Layer_User_Windows_App
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            pnl_HeaderBar = new Panel();
            btn_Minimize = new Button();
            btn_Maximize = new Button();
            btn_Close = new Button();
            pnl_Background = new Panel();
            pnl_HeaderBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_HeaderBar
            // 
            pnl_HeaderBar.BackColor = Color.FromArgb(219, 226, 239);
            pnl_HeaderBar.Controls.Add(btn_Minimize);
            pnl_HeaderBar.Controls.Add(btn_Maximize);
            pnl_HeaderBar.Controls.Add(btn_Close);
            pnl_HeaderBar.Dock = DockStyle.Top;
            pnl_HeaderBar.Location = new Point(0, 0);
            pnl_HeaderBar.Name = "pnl_HeaderBar";
            pnl_HeaderBar.Size = new Size(1280, 40);
            pnl_HeaderBar.TabIndex = 1;
            pnl_HeaderBar.MouseDown += pnl_HeaderBar_MouseDown;
            // 
            // btn_Minimize
            // 
            btn_Minimize.BackColor = Color.FromArgb(0, 0, 0, 0);
            btn_Minimize.Dock = DockStyle.Right;
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(172, 182, 201);
            btn_Minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 204, 220);
            btn_Minimize.FlatStyle = FlatStyle.Flat;
            btn_Minimize.Image = Properties.Resources.img_minimizeForm;
            btn_Minimize.Location = new Point(1055, 0);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(75, 40);
            btn_Minimize.TabIndex = 2;
            btn_Minimize.UseVisualStyleBackColor = false;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // btn_Maximize
            // 
            btn_Maximize.BackColor = Color.FromArgb(0, 0, 0, 0);
            btn_Maximize.Dock = DockStyle.Right;
            btn_Maximize.FlatAppearance.BorderSize = 0;
            btn_Maximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(172, 182, 201);
            btn_Maximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 204, 220);
            btn_Maximize.FlatStyle = FlatStyle.Flat;
            btn_Maximize.Image = Properties.Resources.img_maximizeFormON;
            btn_Maximize.Location = new Point(1130, 0);
            btn_Maximize.Name = "btn_Maximize";
            btn_Maximize.Size = new Size(75, 40);
            btn_Maximize.TabIndex = 1;
            btn_Maximize.UseVisualStyleBackColor = false;
            btn_Maximize.Click += btn_Maximize_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.FromArgb(0, 0, 0, 0);
            btn_Close.Dock = DockStyle.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 0, 0);
            btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 0, 0);
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Image = Properties.Resources.img_closeForm;
            btn_Close.Location = new Point(1205, 0);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 40);
            btn_Close.TabIndex = 0;
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // pnl_Background
            // 
            pnl_Background.BackColor = Color.FromArgb(219, 226, 239);
            pnl_Background.BackgroundImageLayout = ImageLayout.Zoom;
            pnl_Background.Dock = DockStyle.Fill;
            pnl_Background.Location = new Point(0, 40);
            pnl_Background.Name = "pnl_Background";
            pnl_Background.Size = new Size(1280, 680);
            pnl_Background.TabIndex = 2;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnl_Background);
            Controls.Add(pnl_HeaderBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Main";
            Text = "Bank Management System";
            Shown += frm_Main_Shown;
            pnl_HeaderBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_HeaderBar;
        private Button btn_Minimize;
        private Button btn_Maximize;
        private Button btn_Close;
        private Panel pnl_Background;
    }
}