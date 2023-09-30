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
using Zeroit.Framework.LineSeparators;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome
{
    public partial class ucClientBalanceSummary : UserControl
    {
        clsClient client = null;
        public ucClientBalanceSummary(clsClient client)
        {
            this.client = client;
            this.client.Refresh();
            InitializeComponent();

            init_Balance_Recent();
        }

        private void init_Balance_Recent()
        {
            this.lbl_Balance.Text = string.Format("{0:0.00}", client.Balance) + " $";

            DataTable table = client.Transactions_List();

            if (table.Rows.Count > 0)
            {

                lbl_DateTime.Visible = true;
                lbl_LastTransAmount.Visible = true;
                lbl_TransactionType.Visible = true;
                lbl_TimeTitle.Visible = true;
                lbl_Title.Visible = true;

                

                lbl_DateTime.Text = ((DateTime)table.Rows[0]["TransactionDateTime"]).ToString();
                lbl_LastTransAmount.Text = "" + Operation(table.Rows[0]) + (table.Rows[0]["Amount"]).ToString();
                lbl_LastTransAmount.ForeColor = AmountColor(table.Rows[0]);
                lbl_TransactionType.Text = clsTransaction.Types[(int)table.Rows[0]["TransactionType_ID"]];

            }
            else
            {
                lbl_DateTime.Visible = false;
                lbl_LastTransAmount.Visible = false;
                lbl_TransactionType.Visible = false;
                lbl_TimeTitle.Visible = false;
                lbl_Title.Visible = true;
                lbl_Title.Text = "No Transaction is done yet";
            }

            Color AmountColor(DataRow row)
            {
                clsTransaction.enTransaction type = (clsTransaction.enTransaction)row["TransactionType_ID"];

                if (type == clsTransaction.enTransaction.eDeposit)
                {
                    return Color.FromArgb(0, 182, 51);
                }
                else if (type == clsTransaction.enTransaction.eWithdraw)
                {
                    return Color.FromArgb(215, 0, 0);
                }
                else if (type == clsTransaction.enTransaction.eTransfer)
                {
                    if (client.Client_ID == (int)row["Receiver_ID"])
                    {
                        return Color.FromArgb(0, 182, 51);
                    }
                    else
                    {
                        return Color.FromArgb(215, 0, 0);
                    }
                }
                else
                {
                    return Color.Yellow;// Imposible
                }
            }

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

        private void pnl_LastTransaction_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
