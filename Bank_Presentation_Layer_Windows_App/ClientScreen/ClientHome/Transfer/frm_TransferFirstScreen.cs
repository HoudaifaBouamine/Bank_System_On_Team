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
    public partial class frm_TransferFirstScreen : Form
    {
        frm_TransferMainScreen main = null;
        clsClient client;
        public frm_TransferFirstScreen(frm_TransferMainScreen main,clsClient client)
        {
            this.main = main;
            this.client = client;

            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            string AccountNumber = "";
            AccountNumber = tb_AccountNumber.Text.Trim();
            clsClient client = clsClient.Find_AccNum(AccountNumber);

            if(client == null)
            {
                MessageBox.Show($"Client With account number [{AccountNumber}] is Not found","Receiver Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            double Amount = Convert.ToDouble(tb_Amount.Text.Trim().ToString());

            if(Amount > client.Balance)
            {
                MessageBox.Show($"The Amount you entered [{Amount}] is greater than your balance [{client.Balance}]", "Amount not valied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            main.open_chiled_form(new frm_TransferSecondScreen(main,client));
        }
    }
}
