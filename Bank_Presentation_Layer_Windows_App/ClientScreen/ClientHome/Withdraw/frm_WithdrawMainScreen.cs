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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw
{
    public partial class frm_WithdrawMainScreen : Form
    {

        clsClient client = null;
        public frm_WithdrawMainScreen(clsClient client)
        {
            this.client = client;
            InitializeComponent();
        }
    }
}
