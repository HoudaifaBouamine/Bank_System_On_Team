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
    public partial class frm_DepositMainScreen : frm_MainBaseForm
    {
        clsClient client = null;
        Dictionary<string, Form> forms = new Dictionary<string, Form>();
        public clsTransaction transaction = null;
        public frm_DepositMainScreen(clsClient client)
        {
            this.client = client;
            transaction = new clsTransaction(clsTransaction.enTransaction.eDeposit,-1,client.Client_ID,-1,(int)clsTransaction.enTransaction.eDeposit,-1,DateTime.MinValue);
            InitializeComponent();

            frm_DepositFirstScreen  firstScreen  = new frm_DepositFirstScreen(this, client, transaction);
            frm_DepositSecondScreen secondScreen = new frm_DepositSecondScreen(this, client, transaction);

            forms.Add("First", firstScreen);
            forms.Add("Second", secondScreen);

            controler = new clsPagesControler(pnl_Main,forms);
            controler.open_page("First");
        }


        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
