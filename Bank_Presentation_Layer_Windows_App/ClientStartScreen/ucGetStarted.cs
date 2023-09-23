using Bank_Presentation_Layer_Windows_App.ClientStartScreen;
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
    public partial class ucGetStarted : UserControl
    {
        frm_StartScreen startScreen = null;

        public ucGetStarted(frm_StartScreen startScreen)
        {
            this.startScreen = startScreen;
            InitializeComponent();
        }

        private void btn_GetStarted_Click(object sender, EventArgs e)
        {
            this.startScreen.open_child_window(new ucLogin(startScreen));
        }
    }
}
