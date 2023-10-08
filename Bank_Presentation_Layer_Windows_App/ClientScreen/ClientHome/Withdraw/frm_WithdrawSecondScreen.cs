using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer;
using Bank_Presentation_Layer_Windows_App.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw
{
    public partial class frm_WithdrawSecondScreen : Form
    {

        frm_MainBaseForm Main; clsClient Client; clsTransaction Transaction;
        string VerificationKey = "";
        public frm_WithdrawSecondScreen(frm_MainBaseForm main, clsClient client, clsTransaction transaction)
        {
            Main = main;
            Client = client;
            Transaction = transaction;
            InitializeComponent();
            TopLevel = false;

        }



        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            VerificationKey = clsUtil.GenerateVerificationKey(6);

            string Subject = "Subject: Your Verification Key for Transfer transaction";
            string Body = $"Dear {Client.FirstName} {Client.LastName},\r\n\r\nYour recent transaction (Withdraw) with Houdaifa Bamk requires a final step to ensure its security. Please find your unique verification key below:\r\n\r\nVerification Key: {VerificationKey}\r\n\r\nTo complete your transaction, simply copy this verification key and paste it in the designated field on our secure website. This step confirms your authorization and safeguards your financial activity.\r\n\r\nIf you did not initiate this transaction or have any concerns regarding your account's security, please contact our customer support immediately at bank.houdaifa@gmail.com.\r\n\r\nThank you for choosing Houdaifa Bank. We value your trust in us and are committed to keeping your financial information safe.\r\n\r\nSincerely,\r\n\r\nSent by : Verification Bot\r\nBank Name : Houdaifa Bank\r\nContact Information : bank.houdaifa@gmail.com\r\n";

            Client.SendEmail(Subject, Body);
            pnl_CheckSpam.Visible = true;

            btn_SendEmail.Text = "Resend Email";
            tb_VerificationKey.Select();
        }


        void init_Window()
        {
            lbl_Amount.Text = string.Format("{0:0.00}", this.Transaction.Amount) + " $";
        }

        private void btn_Confirme_Click(object sender, EventArgs e)
        {
            if (tb_VerificationKey.Text == "")
            {
                MessageBox.Show("You must enter verification key", "Requered field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (tb_VerificationKey.Text != VerificationKey)
            {
                MessageBox.Show("Verification Key is wrong", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Client.Refresh();

            if (Client.Balance < Transaction.Amount)
            {
                MessageBox.Show($"You can not perform this transaction, your balance [{Client.Balance}] is Less than ammount [{Transaction.Amount}]", "Balance Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client.Withdrawal(ref Transaction);


            if (Transaction == null)
            {
                MessageBox.Show("Somthing Went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Main.controler.open_page("Third");




        }

        private void frm_WithdrawSecondScreen_Load(object sender, EventArgs e)
        {
            init_Window();

        }
    }
}
