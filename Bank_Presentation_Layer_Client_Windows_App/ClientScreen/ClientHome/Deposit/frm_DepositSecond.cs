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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Deposit
{
    public partial class frm_DepositSecondScreen : Form
    {
        clsClient Client;
        frm_MainBaseForm Main;
        clsTransaction Transaction;
        public frm_DepositSecondScreen(frm_MainBaseForm main, clsClient client,clsTransaction transaction)
        {
            Client = client;
            Main = main;
            Transaction = transaction;
            InitializeComponent();
            this.TopLevel = false;

            
        }

        private void frm_DepositSecondScreen_Load(object sender, EventArgs e)
        {
            lbl_Amount.Text = "+"+string.Format("{0:0.00}", Transaction.Amount) + "  $";
            lbl_DateTime.Text = Transaction.TransactionDateTime.ToString();
            lbl_ReceiverAccountNumber.Text = Transaction.Receiver.AccountNumber.ToString();

            clsGlobal.NeedToRefrech = true;
        }

        private void frm_DepositSecondScreen_Validating(object sender, CancelEventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
