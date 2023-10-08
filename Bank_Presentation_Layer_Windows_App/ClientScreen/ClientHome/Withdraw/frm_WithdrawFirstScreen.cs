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
    public partial class frm_WithdrawFirstScreen : Form
    {
        frm_MainBaseForm Main; clsClient Client; clsTransaction Transaction;
        public frm_WithdrawFirstScreen(frm_MainBaseForm main, clsClient client,clsTransaction transaction)
        {
            Main = main;
            Client = client;
            Transaction =  transaction;
            InitializeComponent();
            TopLevel = false;
        }

        private void frm_WithdrawFirstScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            double Amount = Convert.ToDouble( tb_Amount.Text);

            if(Amount <= Client.Balance)
            {
                Transaction.Amount = Amount;
                Main.controler.open_page("Second");
            }
            else
            {
                MessageBox.Show($"Error,Invalid Amount", $"The Amount [{Amount}] you want to withdraw is greater than your Balance [{Client.Balance}]",MessageBoxButtons.OK,MessageBoxIcon.Error);
                // Show message
                return;
            }

        }
    }
}
