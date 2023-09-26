using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientStartScreen;
using Bank_Presentation_Layer_Windows_App.ClientStartScreen.Sub_StartScreens;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            startScreen.open_child_window(new ucLogin(startScreen));
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            clsClient client = new clsClient();

            client.FirstName = tb_FirstName.Text.Trim();
            client.LastName = tb_LastName.Text.Trim();
            client.Email = tb_Email.Text.Trim();
            client.PinCode = tb_PinCode.Text.Trim();

            startScreen.open_child_window(new ucVerifyEmail(startScreen,client));
        }
    }
}
