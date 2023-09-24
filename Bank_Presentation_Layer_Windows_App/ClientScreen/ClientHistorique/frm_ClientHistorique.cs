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
        }


        private void init_Historique()
        {
            dgv_ClientTransactionsList.DataSource = get_table();
        }

        private DataTable get_table()
        {
            DataTable Trans = new DataTable("Transactions List");
            Trans.Columns.Add("Name");
            Trans.Columns.Add("Id");
            Trans.Columns.Add("Amount");
            Trans.Columns.Add("Time");

            DataTable table = client.Transactions_List();

            foreach(DataRow dr in table.Rows)
            {
                clsHisRows hisRows = new clsHisRows();
                hisRows.Name = client.FirstName + " " + client.LastName;
                hisRows.Transaction_Id = (int) dr["Transaction_ID"];
                hisRows.Amount = ""+ Operation(dr) + (dr["Amount"]) + " $";
                hisRows.Time = (DateTime) dr["TransactionDateTime"];

                object[] row = { hisRows.Name , hisRows.Transaction_Id , hisRows.Amount, hisRows.Time };

                
                Trans.Rows.Add(row);
            }

            return Trans;

            char Operation(DataRow row)
            {
                clsTransaction.enTransaction type =  (clsTransaction.enTransaction)row["TransactionType_ID"];

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
                    if(client.Client_ID ==(int) row["Receiver_ID"])
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
    }
}
