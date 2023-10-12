using System.Drawing;

namespace Bank_Presentation_Layer_Windows_App.LoginScreen
{
    partial class frm_StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StartScreen));
            this.pnl_LoginContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_LoginContainer
            // 
            this.pnl_LoginContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_LoginContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_LoginContainer.Location = new System.Drawing.Point(622, 32);
            this.pnl_LoginContainer.Name = "pnl_LoginContainer";
            this.pnl_LoginContainer.Size = new System.Drawing.Size(500, 650);
            this.pnl_LoginContainer.TabIndex = 0;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnl_LoginContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LoginContainer;
    }
}