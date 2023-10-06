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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_TranscationsGraph = new System.Windows.Forms.Panel();
            this.pnl_Balance = new System.Windows.Forms.Panel();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_ClientTransactionsList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.pnl_Balance.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientTransactionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_TranscationsGraph);
            this.panel3.Controls.Add(this.pnl_Balance);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 240);
            this.panel3.TabIndex = 7;
            // 
            // pnl_TranscationsGraph
            // 
            this.pnl_TranscationsGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TranscationsGraph.BackColor = System.Drawing.Color.White;
            this.pnl_TranscationsGraph.Location = new System.Drawing.Point(361, 30);
            this.pnl_TranscationsGraph.Name = "pnl_TranscationsGraph";
            this.pnl_TranscationsGraph.Size = new System.Drawing.Size(539, 180);
            this.pnl_TranscationsGraph.TabIndex = 8;
            // 
            // pnl_Balance
            // 
            this.pnl_Balance.BackColor = System.Drawing.Color.White;
            this.pnl_Balance.Controls.Add(this.lbl_Available);
            this.pnl_Balance.Controls.Add(this.lbl_Balance);
            this.pnl_Balance.Controls.Add(this.label1);
            this.pnl_Balance.Location = new System.Drawing.Point(30, 30);
            this.pnl_Balance.Name = "pnl_Balance";
            this.pnl_Balance.Size = new System.Drawing.Size(301, 180);
            this.pnl_Balance.TabIndex = 6;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.dgv_ClientTransactionsList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(930, 480);
            this.panel5.TabIndex = 8;
            // 
            // dgv_ClientTransactionsList
            // 
            this.dgv_ClientTransactionsList.AllowUserToAddRows = false;
            this.dgv_ClientTransactionsList.AllowUserToDeleteRows = false;
            this.dgv_ClientTransactionsList.AllowUserToOrderColumns = true;
            this.dgv_ClientTransactionsList.AllowUserToResizeColumns = false;
            this.dgv_ClientTransactionsList.AllowUserToResizeRows = false;
            this.dgv_ClientTransactionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ClientTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ClientTransactionsList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ClientTransactionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ClientTransactionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ClientTransactionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClientTransactionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ClientTransactionsList.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ClientTransactionsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ClientTransactionsList.EnableHeadersVisualStyles = false;
            this.dgv_ClientTransactionsList.Location = new System.Drawing.Point(30, 0);
            this.dgv_ClientTransactionsList.Name = "dgv_ClientTransactionsList";
            this.dgv_ClientTransactionsList.ReadOnly = true;
            this.dgv_ClientTransactionsList.RowHeadersVisible = false;
            this.dgv_ClientTransactionsList.RowHeadersWidth = 51;
            this.dgv_ClientTransactionsList.RowTemplate.Height = 45;
            this.dgv_ClientTransactionsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_ClientTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientTransactionsList.Size = new System.Drawing.Size(890, 450);
            this.dgv_ClientTransactionsList.TabIndex = 3;
            this.dgv_ClientTransactionsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ClientTransactionsList_CellFormatting);
            this.dgv_ClientTransactionsList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_ClientTransactionsList_Scroll);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(900, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 480);
            this.panel1.TabIndex = 4;
            // 
            // frm_ClientHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(930, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ClientHistorique";
            this.Text = "ClientHistorique";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_ClientHistorique_Paint);
            this.panel3.ResumeLayout(false);
            this.pnl_Balance.ResumeLayout(false);
            this.pnl_Balance.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientTransactionsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private Panel panel5;
        private DataGridView dgv_ClientTransactionsList;
        private Panel pnl_Balance;
        private Label lbl_Available;
        private Label lbl_Balance;
        private Label label1;
        private Panel pnl_TranscationsGraph;
        private Panel panel1;
    }
}