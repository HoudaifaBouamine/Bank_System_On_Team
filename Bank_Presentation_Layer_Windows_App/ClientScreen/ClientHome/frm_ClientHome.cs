using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome;
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
        public frm_ClientHome(clsClient client)
        {
            this.client = client;
            InitializeComponent();

            ucClientBalanceSummary balanceSummary = new ucClientBalanceSummary(client);
            pnl_Balance.Controls.Add(balanceSummary);
            balanceSummary.Dock = DockStyle.Fill;
        }


        private void frm_ClientHomePage_Load(object sender, EventArgs e)
        {

        }

   
    }
}
