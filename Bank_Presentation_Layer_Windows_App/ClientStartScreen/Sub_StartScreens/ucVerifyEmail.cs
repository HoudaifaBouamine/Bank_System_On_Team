using Bank_Business_Layer;
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

namespace Bank_Presentation_Layer_Windows_App.ClientStartScreen.Sub_StartScreens
{
    public partial class ucVerifyEmail : UserControl
    {
        frm_StartScreen startScreen = null; clsClient client = null;
        public ucVerifyEmail(frm_StartScreen startScreen,clsClient client)
        {
            this.startScreen = startScreen;
            this.client = client;
            InitializeComponent();
        }
    }
}
