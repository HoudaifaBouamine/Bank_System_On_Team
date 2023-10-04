namespace Bank_Presentation_Layer_Windows_App.ClientLoginScreen
{
    partial class ucGetStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGetStarted));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GetStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(-3, 176);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(500, 170);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Welcome to\r\nHoudaifa Bank\r\n";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(-3, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 162);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_GetStarted
            // 
            this.btn_GetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_GetStarted.FlatAppearance.BorderSize = 0;
            this.btn_GetStarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_GetStarted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_GetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetStarted.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_GetStarted.ForeColor = System.Drawing.Color.White;
            this.btn_GetStarted.Location = new System.Drawing.Point(-3, 497);
            this.btn_GetStarted.Name = "btn_GetStarted";
            this.btn_GetStarted.Size = new System.Drawing.Size(201, 44);
            this.btn_GetStarted.TabIndex = 4;
            this.btn_GetStarted.Text = "Get Started";
            this.btn_GetStarted.UseVisualStyleBackColor = false;
            this.btn_GetStarted.Click += new System.EventHandler(this.btn_GetStarted_Click);
            // 
            // ucGetStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_GetStarted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucGetStarted";
            this.Size = new System.Drawing.Size(500, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GetStarted;
    }
}
