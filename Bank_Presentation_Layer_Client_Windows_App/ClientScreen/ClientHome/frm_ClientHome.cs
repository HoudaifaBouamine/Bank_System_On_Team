using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Deposit;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientHome : Form
    {

        clsClient client = null;
        frm_ClientScreen clientScreen = null;
        ucClientBalanceSummary balanceSummary = null;


        public frm_ClientHome(frm_ClientScreen clientScreen,clsClient client)
        {

            this.client = client;
            this.clientScreen = clientScreen;

            InitializeComponent();
            TopLevel = false;


            balanceSummary = new ucClientBalanceSummary(client);

            if(pnl_Balance.Controls.Count != 0)
            {
                pnl_Balance.Controls.Clear();
            }

            pnl_Balance.Controls.Add(balanceSummary);
            balanceSummary.Dock = DockStyle.Fill;

            init_Home();
        }

        public void init_Home()
        {
            balanceSummary.init_Balance_Recent();
        }


        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            clientScreen.open_chiled_form(new frm_DepositMainScreen(client));
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            clientScreen.open_chiled_form(new frm_WithdrawMainScreen(client)); // NOTE (HOUDAIFA) : Add client as parameter
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            clientScreen.open_chiled_form(new frm_TransferMainScreen(client));
        }



        private void frm_ClientHome_Load(object sender, EventArgs e)
        {
            //init_Home();

        }

      

        private void frm_ClientHome_Paint(object sender, PaintEventArgs e)
        {
            if (clsGlobal.Refrech[clsGlobal.enPage.Client_Home])
            {
                init_Home();
                clsGlobal.Refrech[clsGlobal.enPage.Client_Home] = false;
            }

        }


    }
}
