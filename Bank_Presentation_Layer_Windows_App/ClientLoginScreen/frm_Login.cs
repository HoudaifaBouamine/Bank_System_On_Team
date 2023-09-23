using Bank_Presentation_Layer_Windows_App.ClientLoginScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.LoginScreen
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            open_child_window(new ucCreateAccount());
        }

        UserControl currentUserControl = null;
        private void open_child_window(UserControl userControl)
        {
            

            pnl_LoginContainer.Controls.Clear();
            pnl_LoginContainer.Controls.Add(userControl);
            pnl_LoginContainer.Tag = userControl;
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            userControl.Show();

        }
 
    }
}
