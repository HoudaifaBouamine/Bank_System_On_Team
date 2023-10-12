using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw
{
    public partial class frm_WithdrawThirdScreen : Form
    {

        frm_MainBaseForm Main; clsClient Client; clsTransaction Transaction;
        public frm_WithdrawThirdScreen(frm_MainBaseForm main, clsClient client, clsTransaction transaction)
        {
            Main = main;
            Client = client;
            Transaction = transaction;
            InitializeComponent();
            TopLevel = false;

            clsGlobal.NeedToRefrech = true;

        }

        private void lbl_ReceiverAccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void frm_WithdrawSecondScreen_Load(object sender, EventArgs e)
        {
            lbl_Amount.Text = "-" + string.Format("{0:0.00}", Transaction.Amount) + "  $";
            lbl_DateTime.Text = Transaction.TransactionDateTime.ToString();
            lbl_SenderAccountNumber.Text = Transaction.Sender.AccountNumber.ToString();

        }
    }
}
