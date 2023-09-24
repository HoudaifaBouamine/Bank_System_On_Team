using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Balance = new System.Windows.Forms.Panel();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_TranscationsGraph = new System.Windows.Forms.Panel();
            this.pnl_TransactionsList = new System.Windows.Forms.Panel();
            this.dgv_ClientTransactionsList = new System.Windows.Forms.DataGridView();
            this.pnl_Balance.SuspendLayout();
            this.pnl_TransactionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientTransactionsList)).BeginInit();
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
            this.pnl_TransactionsList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnl_TransactionsList.BackColor = System.Drawing.Color.White;
            this.pnl_TransactionsList.Controls.Add(this.dgv_ClientTransactionsList);
            this.pnl_TransactionsList.Location = new System.Drawing.Point(28, 243);
            this.pnl_TransactionsList.Name = "pnl_TransactionsList";
            this.pnl_TransactionsList.Size = new System.Drawing.Size(876, 449);
            this.pnl_TransactionsList.TabIndex = 2;
            // 
            // dgv_ClientTransactionsList
            // 
            this.dgv_ClientTransactionsList.AllowUserToAddRows = false;
            this.dgv_ClientTransactionsList.AllowUserToDeleteRows = false;
            this.dgv_ClientTransactionsList.AllowUserToOrderColumns = true;
            this.dgv_ClientTransactionsList.AllowUserToResizeColumns = false;
            this.dgv_ClientTransactionsList.AllowUserToResizeRows = false;
            this.dgv_ClientTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ClientTransactionsList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ClientTransactionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ClientTransactionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ClientTransactionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClientTransactionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ClientTransactionsList.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 17.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ClientTransactionsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ClientTransactionsList.EnableHeadersVisualStyles = false;
            this.dgv_ClientTransactionsList.Location = new System.Drawing.Point(0, 0);
            this.dgv_ClientTransactionsList.Name = "dgv_ClientTransactionsList";
            this.dgv_ClientTransactionsList.ReadOnly = true;
            this.dgv_ClientTransactionsList.RowHeadersVisible = false;
            this.dgv_ClientTransactionsList.RowHeadersWidth = 51;
            this.dgv_ClientTransactionsList.RowTemplate.Height = 45;
            this.dgv_ClientTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientTransactionsList.Size = new System.Drawing.Size(876, 449);
            this.dgv_ClientTransactionsList.TabIndex = 0;
            this.dgv_ClientTransactionsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ClientTransactionsList_CellFormatting);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientTransactionsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Balance;
        private System.Windows.Forms.Panel pnl_TranscationsGraph;
        private System.Windows.Forms.Panel pnl_TransactionsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.DataGridView dgv_ClientTransactionsList;
    }
}