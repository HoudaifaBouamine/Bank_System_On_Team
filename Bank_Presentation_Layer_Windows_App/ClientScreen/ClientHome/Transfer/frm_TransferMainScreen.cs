using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw;
using Bank_Presentation_Layer_Windows_App.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer
{
    public partial class frm_TransferMainScreen : frm_MainBaseForm
    {

        clsClient Sender = null,Receiver =null;
        Dictionary<string, Form> forms = new Dictionary<string, Form>();
        public clsTransaction transaction = null;
        public frm_TransferMainScreen(clsClient sender)
        {
            this.Sender = sender;
           
            transaction = new clsTransaction(clsTransaction.enTransaction.eTransfer, sender.Client_ID, -1, -1, (int)clsTransaction.enTransaction.eWithdraw, -1, DateTime.MinValue);
            InitializeComponent();

            Receiver = new clsClient();

            forms.Add("First", new frm_TransferFirstScreen(this, sender, Receiver, transaction));
            forms.Add("Second", new frm_TransferSecondScreen(this, sender, Receiver, transaction));
            forms.Add("Third", new frm_TransferThirdScreen(this, sender, Receiver, transaction));

            controler = new clsPagesControler(pnl_Main, forms);
        }
       
        private void frm_TransferMainScreen_Load(object sender, EventArgs e)
        {
            controler.open_page("First");
        }
    }
}
