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
    public partial class frm_DepositMainScreen : Form
    {
        clsClient client = null;
        Dictionary<string, Form> forms = new Dictionary<string, Form>();
        public frm_DepositMainScreen(clsClient client)
        {
            this.client = client;
            InitializeComponent();

            forms.Add("First", new frm_DepositFirstScreen(this,client));
            forms.Add("Second", new frm_DepositSecondScreen(this, client));
            forms.Add("Third", new frm_DepositThirdScreen(this, client));

            controler = new clsPagesControler(pnl_Main,forms);
            controler.open_page("First");
        }

        internal clsPagesControler controler = null;
    }
}
