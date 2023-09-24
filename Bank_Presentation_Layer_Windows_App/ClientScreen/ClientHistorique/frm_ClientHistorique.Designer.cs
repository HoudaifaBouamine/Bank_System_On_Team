﻿namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    partial class frm_ClientHistorique
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
            this.pnl_TranscationsGraph = new System.Windows.Forms.Panel();
            this.pnl_TransactionsList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Balance.SuspendLayout();
            this.pnl_TransactionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Balance
            // 
            this.pnl_Balance.BackColor = System.Drawing.Color.White;
            this.pnl_Balance.Controls.Add(this.lbl_Available);
            this.pnl_Balance.Controls.Add(this.lbl_Balance);
            this.pnl_Balance.Controls.Add(this.label1);
            this.pnl_Balance.Location = new System.Drawing.Point(28, 25);
            this.pnl_Balance.Name = "pnl_Balance";
            this.pnl_Balance.Size = new System.Drawing.Size(301, 187);
            this.pnl_Balance.TabIndex = 0;
            // 
            // pnl_TranscationsGraph
            // 
            this.pnl_TranscationsGraph.BackColor = System.Drawing.Color.White;
            this.pnl_TranscationsGraph.Location = new System.Drawing.Point(359, 25);
            this.pnl_TranscationsGraph.Name = "pnl_TranscationsGraph";
            this.pnl_TranscationsGraph.Size = new System.Drawing.Size(545, 187);
            this.pnl_TranscationsGraph.TabIndex = 1;
            // 
            // pnl_TransactionsList
            // 
            this.pnl_TransactionsList.BackColor = System.Drawing.Color.White;
            this.pnl_TransactionsList.Controls.Add(this.dataGridView1);
            this.pnl_TransactionsList.Location = new System.Drawing.Point(28, 243);
            this.pnl_TransactionsList.Name = "pnl_TransactionsList";
            this.pnl_TransactionsList.Size = new System.Drawing.Size(876, 449);
            this.pnl_TransactionsList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.Font = new System.Drawing.Font("Arial", 17.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(11, 70);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(237, 30);
            this.lbl_Balance.TabIndex = 1;
            this.lbl_Balance.Text = "$9381 USD";
            this.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Available
            // 
            this.lbl_Available.AutoSize = true;
            this.lbl_Available.Font = new System.Drawing.Font("Arial", 8.2F);
            this.lbl_Available.Location = new System.Drawing.Point(13, 126);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(64, 16);
            this.lbl_Available.TabIndex = 2;
            this.lbl_Available.Text = "Available";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // frm_ClientHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(930, 720);
            this.Controls.Add(this.pnl_TransactionsList);
            this.Controls.Add(this.pnl_TranscationsGraph);
            this.Controls.Add(this.pnl_Balance);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ClientHistorique";
            this.Text = "ClientHistorique";
            this.pnl_Balance.ResumeLayout(false);
            this.pnl_Balance.PerformLayout();
            this.pnl_TransactionsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Balance;
        private System.Windows.Forms.Panel pnl_TranscationsGraph;
        private System.Windows.Forms.Panel pnl_TransactionsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}