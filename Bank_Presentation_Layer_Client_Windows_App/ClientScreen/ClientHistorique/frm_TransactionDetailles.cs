using Bank_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHistorique
{
    public partial class frm_TransactionDetailles : Form
    {
        public frm_TransactionDetailles()
        {
            InitializeComponent();
            
        }

        clsTransaction _Transaction = null;

        public clsTransaction Transaction
        {
            get
            {
                return _Transaction;
            }

            set
            {
                _Transaction = value;

                Reload();
            }
        }

        private void Reload()
        {
            lbl_TransactionType.Text = "" + clsTransaction.TransactionTypes[Transaction.TransactionType_ID];
            lbl_Amount.Text          = "Amount : " + Transaction.Amount.ToString() + "$";
            lbl_DateTime.Text        = "Date Time : " + Transaction.TransactionDateTime.ToString();
            lbl_ID.Text              = "Transaction ID : " + Transaction.Transaction_ID.ToString();

            if (Transaction.Receiver != null)
            {
                lbl_ReceiverAccNum.Visible = true;
                lbl_ReceiverAccNum.Text = "Receiver Account Number : " + Transaction.Receiver.AccountNumber;
                lbl_ReceiverName.Text = "Receiver Name : " + Transaction.Receiver.FullName;
            }
            else
            {
                lbl_ReceiverAccNum.Visible = false;
                lbl_ReceiverName.Visible = false;
            }

            if(Transaction.Sender != null)
            {
                lbl_SenderAccNum.Visible = true;
                lbl_SenderAccNum.Text = "Sender Account Number : " + Transaction.Sender.AccountNumber;
                lbl_SenderName.Text = "Sender Name : " + Transaction.Sender.FullName;
            }
            else
            {
                lbl_SenderAccNum.Visible = false;
                lbl_SenderName.Visible = false;
            }

            

            this.Visible = false;
        }

        private void TransactionDetailles_Load(object sender, EventArgs e)
        {
            if(_Transaction == null) { return; }

            Reload();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(31, 60, 108);
            ((Label)sender).ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
            ((Label)sender).ForeColor = Color.Black;
        }
    }
}
