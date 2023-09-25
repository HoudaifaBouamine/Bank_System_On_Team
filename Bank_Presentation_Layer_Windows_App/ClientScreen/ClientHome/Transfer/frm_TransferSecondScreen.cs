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
        clsClient client;
        public frm_TransferSecondScreen(frm_TransferMainScreen main, clsClient client)
        {
            this.main = main;
            this.client = client;

            InitializeComponent();
        }
    }
}
