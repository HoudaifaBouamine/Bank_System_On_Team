namespace Bank_Presentation_Layer_Windows_App.ClientStartScreen.Sub_StartScreens
{
    partial class ucEnterPhoneNumber
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_VerificationKey = new System.Windows.Forms.MaskedTextBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Skip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_Skip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_VerificationKey);
            this.panel1.Controls.Add(this.btn_Continue);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 387);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phone";
            // 
            // tb_VerificationKey
            // 
            this.tb_VerificationKey.AsciiOnly = true;
            this.tb_VerificationKey.BackColor = System.Drawing.SystemColors.Window;
            this.tb_VerificationKey.Font = new System.Drawing.Font("Arial", 14F);
            this.tb_VerificationKey.Location = new System.Drawing.Point(47, 159);
            this.tb_VerificationKey.Name = "tb_VerificationKey";
            this.tb_VerificationKey.Size = new System.Drawing.Size(401, 34);
            this.tb_VerificationKey.TabIndex = 20;
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Continue.FlatAppearance.BorderSize = 0;
            this.btn_Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_Continue.ForeColor = System.Drawing.Color.White;
            this.btn_Continue.Location = new System.Drawing.Point(47, 238);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(401, 44);
            this.btn_Continue.TabIndex = 22;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = false;
            // 
            // btn_Skip
            // 
            this.btn_Skip.BackColor = System.Drawing.Color.White;
            this.btn_Skip.FlatAppearance.BorderSize = 2;
            this.btn_Skip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Skip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Skip.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_Skip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Skip.Location = new System.Drawing.Point(47, 297);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(401, 44);
            this.btn_Skip.TabIndex = 24;
            this.btn_Skip.Text = "Skip";
            this.btn_Skip.UseVisualStyleBackColor = false;
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // ucEnterPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucEnterPhoneNumber";
            this.Size = new System.Drawing.Size(500, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_VerificationKey;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Skip;
    }
}
