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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome
{
    public partial class ucClientBalanceSummary : UserControl
    {
        clsClient client = null;
        public ucClientBalanceSummary(clsClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void init_Balance_Recent()
        {
            this.lbl_Balance.Text = string.Format("{0:0.00}", client.Balance) + " $";

            // NOTE (HOUDAIFA) : You must modify the database to get the latest trans of the user
        }

    }
}
