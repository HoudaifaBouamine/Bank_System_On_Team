using Bank_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Web.UI;
using System.Windows.Forms.DataVisualization;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientHistorique : Form
    {
        clsClient client = null;
        public frm_ClientHistorique(clsClient client)
        {
            this.client = client;

            InitializeComponent();
            init_Historique();
            TopLevel = false;
        }

        
        //public void init_Historique()
        //{


        //    List<Tuple<double, double>> money_io_per_day =new List<Tuple<double, double>>(30);
        //    DataTable transactionsTable = get_table(money_io_per_day);
        //    dgv_ClientTransactionsList.DataSource = transactionsTable;
        //    lbl_Balance.Text = string.Format("{0:0.00}", client.Balance) + "$";

            
        //    chart_MoneyIO.DataSource = money_io_per_day;
        //}

        //private DataTable get_table(List<Tuple<double, double>> money_io_per_day)
        //{
        //    DataTable Trans = new DataTable("Transactions List");
        //    Trans.Columns.Add("Name");
        //    Trans.Columns.Add("Id");
        //    Trans.Columns.Add("Amount");
        //    Trans.Columns.Add("Time");

        //    DataTable table = client.Transactions_List();

        //    for(int i = 0; i < money_io_per_day.Capacity; i++)
        //    {
        //        money_io_per_day.Add(new Tuple<double, double>(0,0));
        //    }

        //    foreach(DataRow dr in table.Rows)
        //    {
        //        clsHisRows hisRows = new clsHisRows();
        //        hisRows.Name = client.FirstName + " " + client.LastName;
        //        hisRows.Transaction_Id = (int) dr["Transaction_ID"];
        //        hisRows.Amount = ""+ Operation(dr) + (dr["Amount"]) + " $";
        //        hisRows.Time = (DateTime) dr["TransactionDateTime"];

        //        object[] row = { hisRows.Name , hisRows.Transaction_Id , hisRows.Amount, hisRows.Time };

                
        //        Trans.Rows.Add(row);

        //        TimeSpan timeSpan = DateTime.Now - hisRows.Time;

        //        if (timeSpan < new TimeSpan(30, 0, 0, 0))
        //        {
        //            double money = Convert.ToDouble(dr["Amount"]);

        //            if (money < 0)
        //            {

        //            }



        //            money_io_per_day[timeSpan.Days] = new Tuple<double, double>(18,5);
        //        }
        //    }

        //    return Trans;

        //    char Operation(DataRow row)
        //    {
        //        clsTransaction.enTransaction type =  (clsTransaction.enTransaction)row["TransactionType_ID"];

        //        if (type == clsTransaction.enTransaction.eDeposit)
        //        {
        //            return '+';
        //        }
        //        else if (type == clsTransaction.enTransaction.eWithdraw)
        //        {
        //            return '-';
        //        }
        //        else if (type == clsTransaction.enTransaction.eTransfer)
        //        {
        //            if(client.Client_ID ==(int) row["Receiver_ID"])
        //            {
        //                return '+';
        //            }
        //            else
        //            {
        //                return '-';
        //            }
        //        }

        //        return ':';
        //    }
        //}


        public void init_Historique()
        {


            List <Tuple<double, double>> money_io_per_day = new List<Tuple<double, double>>(30);
            DataTable transactionsTable = get_table(money_io_per_day);
            dgv_ClientTransactionsList.DataSource = transactionsTable;
            lbl_Balance.Text = string.Format("{0:0.00}", client.Balance) + "$";


            for (int i = 0; i < money_io_per_day.Count; i++) {

                chart_MoneyIO.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint((DateTime.Now).Day - i, money_io_per_day[i].Item1));
                chart_MoneyIO.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint((DateTime.Now).Day - i, money_io_per_day[i].Item2));

            }
        }

        private DataTable get_table(List<Tuple<double, double>> money_io_per_day)
        {
            DataTable Trans = new DataTable("Transactions List");
            Trans.Columns.Add("Name");
            Trans.Columns.Add("Id");
            Trans.Columns.Add("Amount");
            Trans.Columns.Add("Time");

            DataTable table = client.Transactions_List();

            for (int i = 0; i < money_io_per_day.Capacity; i++)
            {
                money_io_per_day.Add(new Tuple<double,double>(0,0));
            }

            foreach (DataRow dr in table.Rows)
            {
                clsHisRows hisRows = new clsHisRows();
                hisRows.Name = client.FirstName + " " + client.LastName;
                hisRows.Transaction_Id = (int)dr["Transaction_ID"];
                hisRows.Amount = "" + Operation(dr) + (dr["Amount"]) + " $";
                hisRows.Time = (DateTime)dr["TransactionDateTime"];

                object[] row = { hisRows.Name, hisRows.Transaction_Id, hisRows.Amount, hisRows.Time };


                Trans.Rows.Add(row);

                TimeSpan timeSpan = DateTime.Now - hisRows.Time;

                if (timeSpan < new TimeSpan(30, 0, 0, 0))
                {
                    double money = Convert.ToDouble(dr["Amount"]);

                    if (money < 0) money *= -1;

                    if (Operation(dr) == '-')
                    {
                        money_io_per_day[timeSpan.Days] = new Tuple<double,double>(money_io_per_day[timeSpan.Days].Item1 + money, money_io_per_day[timeSpan.Days].Item2);

                    }
                    else
                    {
                        money_io_per_day[timeSpan.Days] = new Tuple<double, double>(money_io_per_day[timeSpan.Days].Item1, money_io_per_day[timeSpan.Days].Item2 + money);
                    }


                }
            }

            return Trans;

            char Operation(DataRow row)
            {
                clsTransaction.enTransaction type = (clsTransaction.enTransaction)row["TransactionType_ID"];

                if (type == clsTransaction.enTransaction.eDeposit)
                {
                    return '+';
                }
                else if (type == clsTransaction.enTransaction.eWithdraw)
                {
                    return '-';
                }
                else if (type == clsTransaction.enTransaction.eTransfer)
                {
                    if (client.Client_ID == (int)row["Receiver_ID"])
                    {
                        return '+';
                    }
                    else
                    {
                        return '-';
                    }
                }

                return ':';
            }
        }

        public class clsHisRows
        {
            public string Name;
            public int Transaction_Id;
            public string Amount;
            public DateTime Time;
        }

        private void dgv_ClientTransactionsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           

            if (e.ColumnIndex != 2) return;

            if (e.Value.ToString()[0] == '+')
            {
                e.CellStyle.ForeColor = Color.FromArgb(0, 182, 51);
            }
            else if (e.Value.ToString()[0] == '-')
            {
                e.CellStyle.ForeColor = Color.FromArgb(215, 0, 0);

            }

        }


      

        private void dgv_ClientTransactionsList_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void frm_ClientHistorique_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frm_ClientHistorique_Enter(object sender, EventArgs e)
        {
           
        }

        private void frm_ClientHistorique_Resize(object sender, EventArgs e)
        {

        }

        private void frm_ClientHistorique_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void frm_ClientHistorique_VisibleChanged(object sender, EventArgs e)
        {
            if(!Visible) { return; }

            if (clsGlobal.Refrech[clsGlobal.enPage.Client_Historique])
            {
                init_Historique();
                clsGlobal.Refrech[clsGlobal.enPage.Client_Historique] = false;
            }
        }

        private void frm_ClientHistorique_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_ClientTransactionsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_ClientTransactionsList.SelectedRows[0].
        }

        private void tsmi_ShowDetailles_Click(object sender, EventArgs e)
        {


            DataRow dr = ((DataRowView) dgv_ClientTransactionsList.SelectedRows[0].DataBoundItem).Row;

            int Transaction_ID_Index = 1;

            int Transaction_ID = Convert.ToInt32(dr[Transaction_ID_Index]);

            clsGlobal.Show_Transaction_Detailles(clsTransaction.Find(Transaction_ID));

        }

        private void dgv_ClientTransactionsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_ClientTransactionsList.CurrentCell = dgv_ClientTransactionsList[e.ColumnIndex, e.RowIndex];
            }
        }
    }
}
