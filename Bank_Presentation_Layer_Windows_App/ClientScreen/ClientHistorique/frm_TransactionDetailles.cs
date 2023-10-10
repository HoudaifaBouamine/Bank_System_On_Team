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
            tb_Amount.Text = Transaction.Amount.ToString();
            tb_ID.Text = Transaction.Transaction_ID.ToString();

            if (Transaction.Sender != null)
            {
                tb_Sender_AccountNumber.Text = Transaction.Sender.AccountNumber.ToString();
            }
            else
            {
                tb_Sender_AccountNumber.Text = "NULL";

            }


            if (Transaction.Receiver != null)
            {
                tb_Receiver_AccountNumber.Text = Transaction.Receiver.AccountNumber.ToString();
            }
            else
            {
                tb_Receiver_AccountNumber.Text = "NULL";

            }

            this.Visible = false;
        }

        private void TransactionDetailles_Load(object sender, EventArgs e)
        {
            if(_Transaction == null) { return; }

            Reload();
        }
    }
}
