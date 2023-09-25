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
        public frm_ClientHome(frm_ClientScreen clientScreen,clsClient client)
        {

            this.client = client;
            this.clientScreen = clientScreen;

            InitializeComponent();

            ucClientBalanceSummary balanceSummary = new ucClientBalanceSummary(client);
            pnl_Balance.Controls.Add(balanceSummary);
            balanceSummary.Dock = DockStyle.Fill;

        }
        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            clientScreen.open_chiled_form(new frm_DepositMainScreen(client));
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            clientScreen.open_chiled_form(new frm_WithdrawMainScreen(client));
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            clientScreen.open_chiled_form(new frm_TransferMainScreen(client));
        }
    }
}
