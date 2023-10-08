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
    public partial class frm_TransferThirdScreen : Form
    {
 
        
        frm_MainBaseForm Main = null;
        clsClient Sender = null, Receiver = null;
        clsTransaction Transaction = null;
        string VerificationKey;

        public frm_TransferThirdScreen(frm_MainBaseForm Main, clsClient Sender, clsClient Receiver, clsTransaction Transaction)
        {
            this.Main = Main;
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Transaction = Transaction;

            InitializeComponent();
            TopLevel = false;

            clsGlobal.NeedToRefrech = true;

        }

        private void frm_TransferThirdScreen_Load(object sender, EventArgs e)
        {
            init_StatusWindow();

        }

        private void init_StatusWindow()
        {
            lbl_Amount.Text = "-" + string.Format("{0:0.00}", Transaction.Amount) + "  $";
            lbl_DateTime.Text = Transaction.TransactionDateTime.ToString();
            lbl_ReceiverAccountNumber.Text = Receiver.AccountNumber.ToString();
            lbl_SenderAccountNumber.Text = Sender.AccountNumber.ToString();
        }

        
    }
}
