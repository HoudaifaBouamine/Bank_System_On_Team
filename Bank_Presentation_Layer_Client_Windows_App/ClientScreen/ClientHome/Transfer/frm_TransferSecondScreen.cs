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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer
{
    public partial class frm_TransferSecondScreen : Form
    {

        frm_MainBaseForm Main = null;
        clsClient Sender = null, Receiver = null;
        clsTransaction Transaction = null;
        string VerificationKey;

        public frm_TransferSecondScreen(frm_MainBaseForm Main, clsClient Sender, clsClient Receiver, clsTransaction Transaction)
        {
            this.Main = Main;
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Transaction = Transaction;

            InitializeComponent();
            TopLevel = false;
        }
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {

            VerificationKey = clsUtil.GenerateVerificationKey(6);

            string Subject = "Subject: Your Verification Key for Transfer transaction";
            string Body = $"Dear {Sender.FirstName} {Sender.LastName},\r\n\r\nYour recent transaction (Trasfer money to other acount) with Houdaifa Bamk requires a final step to ensure its security. Please find your unique verification key below:\r\n\r\nVerification Key: {VerificationKey}\r\n\r\nTo complete your transaction, simply copy this verification key and paste it in the designated field on our secure website. This step confirms your authorization and safeguards your financial activity.\r\n\r\nIf you did not initiate this transaction or have any concerns regarding your account's security, please contact our customer support immediately at bank.houdaifa@gmail.com.\r\n\r\nThank you for choosing Houdaifa Bank. We value your trust in us and are committed to keeping your financial information safe.\r\n\r\nSincerely,\r\n\r\nSent by : Verification Bot\r\nBank Name : Houdaifa Bank\r\nContact Information : bank.houdaifa@gmail.com\r\n";

            Sender.SendEmail(Subject,Body);
            pnl_CheckSpam.Visible = true;

            btn_SendEmail.Text = "Resend Email";
            tb_VerificationKey.Select();
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

            this.Sender.Refresh();

            if(Sender.Balance < Transaction.Amount)
            {
                MessageBox.Show($"You can not perform this transaction, your balance [{Sender.Balance}] is Less than ammount [{Transaction.Amount}]", "Balance Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTransaction transaction = Sender.Transfer(Receiver, Transaction.Amount);

            if (transaction == null)
            {
                MessageBox.Show("Somthing Went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Main.controler.open_page("Third");

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_TransferSecondScreen_Load(object sender, EventArgs e)
        {
            init_Window();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ReceiverAccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Amount_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_VerificationKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnl_CheckSpam_Paint(object sender, PaintEventArgs e)
        {

        }

        void init_Window()
        {
            lbl_Amount.Text = string.Format("{0:0.00}", this.Transaction.Amount) + " $";
            lbl_ReceiverAccountNumber.Text = this.Receiver.AccountNumber;
        }
    }
}
