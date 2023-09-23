using Bank_Presentation_Layer_Windows_App.LoginScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientLoginScreen
{
    public partial class ucCreateAccount : UserControl
    {
        frm_StartScreen startScreen = null;
        public ucCreateAccount(frm_StartScreen startScreen)
        {
            this.startScreen = startScreen;
            InitializeComponent();
        }

        private void ucCreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
