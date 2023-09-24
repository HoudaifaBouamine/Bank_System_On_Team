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
    public partial class frm_StartScreen : Form
    {
        public frm_MainForm mainForm = null;
        public frm_StartScreen(frm_MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            open_child_window(new ucGetStarted(this));
        }

        UserControl currentUserControl = null;
        public void open_child_window(UserControl userControl)
        {

            UserControl prev_Control = null;

            if(pnl_LoginContainer.Controls.Count > 0)
            {
                prev_Control = (UserControl)pnl_LoginContainer.Controls[0];
            }
            

            pnl_LoginContainer.Controls.Add(userControl);
            pnl_LoginContainer.Tag = userControl;
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            userControl.Show();

            if(prev_Control != null)
            {
                pnl_LoginContainer.Controls.Remove(prev_Control);
            }
            

        }

    }
}
