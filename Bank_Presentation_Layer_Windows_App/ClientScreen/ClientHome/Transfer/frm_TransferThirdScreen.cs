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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer
{
    public partial class frm_TransferThirdScreen : Form
    {
        clsTransaction transaction = null;
        clsClient Sender; clsClient Receiver;
        public frm_TransferThirdScreen(clsTransaction transaction,clsClient Sender,clsClient Receiver)
        {
            this.transaction = transaction;
            InitializeComponent();
        }

        private void init_StatusWindow()
        {
            lbl_Amount.Text=  string.Format("{0:0.00}", transaction.Amount) + "  $";
            lbl_DateTime.Text = transaction.TransactionDateTime.ToString();
            lbl_ReceiverAccountNumber.Text = Receiver.AccountNumber;
            lbl_SenderAccountNumber.Text = Sender.AccountNumber;
        }

        
    }
}
