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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_TranscationsGraph = new System.Windows.Forms.Panel();
            this.chart_MoneyIO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Balance = new System.Windows.Forms.Panel();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ClientTransactionsList = new System.Windows.Forms.DataGridView();
            this.cms_Transaction_Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_ShowDetailles = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.pnl_TranscationsGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MoneyIO)).BeginInit();
            this.pnl_Balance.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientTransactionsList)).BeginInit();
            this.cms_Transaction_Context.SuspendLayout();
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
            this.pnl_TranscationsGraph.Controls.Add(this.chart_MoneyIO);
            this.pnl_TranscationsGraph.Location = new System.Drawing.Point(361, 30);
            this.pnl_TranscationsGraph.Name = "pnl_TranscationsGraph";
            this.pnl_TranscationsGraph.Size = new System.Drawing.Size(539, 180);
            this.pnl_TranscationsGraph.TabIndex = 8;
            // 
            // chart_MoneyIO
            // 
            this.chart_MoneyIO.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            chartArea1.AxisY.MajorGrid.LineWidth = 3;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.MajorTickMark.Size = 0F;
            chartArea1.Name = "ChartArea1";
            this.chart_MoneyIO.ChartAreas.Add(chartArea1);
            this.chart_MoneyIO.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BorderWidth = 0;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "lgnd_MonyOut";
            this.chart_MoneyIO.Legends.Add(legend1);
            this.chart_MoneyIO.Location = new System.Drawing.Point(0, 0);
            this.chart_MoneyIO.Margin = new System.Windows.Forms.Padding(0);
            this.chart_MoneyIO.Name = "chart_MoneyIO";
            this.chart_MoneyIO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_MoneyIO.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(145)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))))};
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            series1.CustomProperties = "DrawSideBySide=False";
            series1.Legend = "lgnd_MonyOut";
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.MarkerSize = 8;
            series1.Name = "Money out";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "lgnd_MonyOut";
            series2.MarkerColor = System.Drawing.Color.Blue;
            series2.MarkerSize = 8;
            series2.Name = "Money in";
            this.chart_MoneyIO.Series.Add(series1);
            this.chart_MoneyIO.Series.Add(series2);
            this.chart_MoneyIO.Size = new System.Drawing.Size(539, 180);
            this.chart_MoneyIO.TabIndex = 0;
            this.chart_MoneyIO.Text = "chrt_Money_Out_In";
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
            this.lbl_Balance.Location = new System.Drawing.Point(24, 70);
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(900, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 480);
            this.panel1.TabIndex = 4;
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
            this.dgv_ClientTransactionsList.RowTemplate.ContextMenuStrip = this.cms_Transaction_Context;
            this.dgv_ClientTransactionsList.RowTemplate.Height = 45;
            this.dgv_ClientTransactionsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_ClientTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientTransactionsList.Size = new System.Drawing.Size(890, 456);
            this.dgv_ClientTransactionsList.TabIndex = 3;
            this.dgv_ClientTransactionsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ClientTransactionsList_CellDoubleClick);
            this.dgv_ClientTransactionsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ClientTransactionsList_CellFormatting);
            this.dgv_ClientTransactionsList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ClientTransactionsList_CellMouseDown);
            this.dgv_ClientTransactionsList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_ClientTransactionsList_Scroll);
            // 
            // cms_Transaction_Context
            // 
            this.cms_Transaction_Context.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Transaction_Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ShowDetailles});
            this.cms_Transaction_Context.Name = "cms_Transaction_Context";
            this.cms_Transaction_Context.Size = new System.Drawing.Size(177, 28);
            // 
            // tsmi_ShowDetailles
            // 
            this.tsmi_ShowDetailles.Name = "tsmi_ShowDetailles";
            this.tsmi_ShowDetailles.Size = new System.Drawing.Size(176, 24);
            this.tsmi_ShowDetailles.Text = "Show Detailles";
            this.tsmi_ShowDetailles.Click += new System.EventHandler(this.tsmi_ShowDetailles_Click);
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
            this.Load += new System.EventHandler(this.frm_ClientHistorique_Load);
            this.VisibleChanged += new System.EventHandler(this.frm_ClientHistorique_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_ClientHistorique_Paint);
            this.Enter += new System.EventHandler(this.frm_ClientHistorique_Enter);
            this.Resize += new System.EventHandler(this.frm_ClientHistorique_Resize);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.frm_ClientHistorique_Validating);
            this.panel3.ResumeLayout(false);
            this.pnl_TranscationsGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_MoneyIO)).EndInit();
            this.pnl_Balance.ResumeLayout(false);
            this.pnl_Balance.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientTransactionsList)).EndInit();
            this.cms_Transaction_Context.ResumeLayout(false);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MoneyIO;
        private ContextMenuStrip cms_Transaction_Context;
        private ToolStripMenuItem tsmi_ShowDetailles;
    }
}