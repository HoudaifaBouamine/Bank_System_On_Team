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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Deposit
{
    public partial class frm_DepositSecondScreen : Form
    {
        clsClient Client;
        frm_DepositMainScreen Main;
        public frm_DepositSecondScreen(frm_DepositMainScreen main, clsClient client)
        {
            Client = client;
            Main = main;
            InitializeComponent();
            this.TopLevel = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.controler.open_page("Third");
        }
    }
}
