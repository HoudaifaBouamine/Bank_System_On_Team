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
    public partial class frm_DepositFirstScreen : Form
    {
        clsClient Client;
        frm_MainBaseForm Main;
        clsTransaction Transaction;
        public frm_DepositFirstScreen(frm_MainBaseForm main,clsClient client,clsTransaction transaction)
        {
            Client = client;
            Main = main;
            Transaction = transaction;
            InitializeComponent();
            this.TopLevel = false;
        }

        private async void btn_Next_Click(object sender, EventArgs e)
        {
            double Amount = Convert.ToDouble(tb_Amount.Text);

            // Check if Money on the ATM 

            Transaction.ReceiverBalanceBefore = Client.Balance;
            Transaction.ReceiverBalanceAfter = Client.Balance + Amount;
            Transaction.Amount = Amount;
            Transaction.TransactionDateTime = DateTime.Now;



            Client.Balance += Amount;


            Transaction.Save();
            Client.Save();

            Main.controler .open_page("Second");
        }

        private void frm_DepositFirstScreen_Shown(object sender, EventArgs e)
        {
            tb_Amount.Select();

        }
    }
}
