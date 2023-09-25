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
    public partial class frm_TransferSecondScreen : Form
    {

        frm_TransferMainScreen main = null;
        clsClient Sender,Receiver;
        double Amount;
        string VerificationKey;
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {

            VerificationKey = GenerateVerificationKey();
            string Subject = "Subject: Your Verification Key for Transfer transaction";
            string Body = $"Dear {Sender.FirstName} {Sender.LastName},\r\n\r\nYour recent transaction (Trasfer money to other acount) with Houdaifa Bamk requires a final step to ensure its security. Please find your unique verification key below:\r\n\r\nVerification Key: {VerificationKey}\r\n\r\nTo complete your transaction, simply copy this verification key and paste it in the designated field on our secure website. This step confirms your authorization and safeguards your financial activity.\r\n\r\nIf you did not initiate this transaction or have any concerns regarding your account's security, please contact our customer support immediately at bank.houdaifa@gmail.com.\r\n\r\nThank you for choosing Houdaifa Bank. We value your trust in us and are committed to keeping your financial information safe.\r\n\r\nSincerely,\r\n\r\nSent by : Verification Bot\r\nBank Name : Houdaifa Bank\r\nContact Information : bank.houdaifa@gmail.com\r\n";

            Sender.SendEmail(Subject,Body);
            pnl_CheckSpam.Visible = true;

            btn_SendEmail.Text = "Resend Email";

            string GenerateVerificationKey()
            {
                Random random = new Random();
                StringBuilder verificationKeyBuilder = new StringBuilder();

                for (int i = 0; i < 6; i++)
                {
                    int digit = random.Next(0, 10); // Generates a random digit from 0 to 9
                    verificationKeyBuilder.Append(digit);
                }

                return verificationKeyBuilder.ToString();
            }
        }

        private void btn_Confirme_Click(object sender, EventArgs e)
        {
            if(tb_VerificationKey.Text == "")
            {
                MessageBox.Show("You must enter verification key","Requered field",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            if (tb_VerificationKey.Text != VerificationKey)
            {
                MessageBox.Show("Verification Key is wrong", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTransaction transaction = Sender.Transfer(Receiver, Amount);

            if (transaction == null)
            {
                MessageBox.Show("Somthing Went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            main.open_chiled_form(new frm_TransferThirdScreen(transaction, Sender, Receiver));

        }

        public frm_TransferSecondScreen(frm_TransferMainScreen main, clsClient Sender,clsClient Receiver,double Amount)
        {
            this.main = main;
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Amount = Amount;



            InitializeComponent();
        }
    }
}
