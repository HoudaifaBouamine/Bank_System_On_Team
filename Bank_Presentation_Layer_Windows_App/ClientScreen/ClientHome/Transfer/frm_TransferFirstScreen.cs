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
        clsClient Sender = null;
        public frm_TransferFirstScreen(frm_TransferMainScreen main,clsClient client)
        {
            this.main = main;
            this.Sender = client;
            
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            string Receiver_AccountNumber = "";
            Receiver_AccountNumber = tb_AccountNumber.Text.Trim();

            if(Receiver_AccountNumber == Sender.AccountNumber)
            {
                MessageBox.Show($"The Receiver account number is the same of the sender account number", "You can not send mony to your self", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsClient Receiver = clsClient.Find_AccNum(Receiver_AccountNumber);

            if(Receiver == null)
            {
                MessageBox.Show($"Client With account number [{Receiver_AccountNumber}] is Not found","Receiver Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            this.Sender.Refresh();
            double Amount = Convert.ToDouble(tb_Amount.Text.Trim().ToString());

            if(Amount > Receiver.Balance)
            {
                MessageBox.Show($"The Amount you entered [{Amount}] is greater than your balance [{Sender.Balance}]", "Amount not valied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            main.open_chiled_form(new frm_TransferSecondScreen(main,Sender,Receiver,Amount));
        }
    }
}
