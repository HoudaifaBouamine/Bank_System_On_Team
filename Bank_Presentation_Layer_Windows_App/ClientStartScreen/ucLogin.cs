using Bank_Presentation_Layer_Windows_App.ClientLoginScreen;
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

namespace Bank_Presentation_Layer_Windows_App.ClientStartScreen
{
    public partial class ucLogin : UserControl
    {
        frm_StartScreen startScreen = null;
        public ucLogin(frm_StartScreen startScreen)
        {
            this.startScreen = startScreen;
            InitializeComponent();
        }


        #region LoginSettings

        private void change_login_requrments()
        {
            if (cb_Login_as_user.Checked)
            {
                lbl_Password_Or_PinCode.Text = "Password";

                if (!cb_Login_Email.Checked)
                {
                    lbl_Email_or_AccNum_or_UserName.Text = "User Name";
                }
                else
                {
                    lbl_Email_or_AccNum_or_UserName.Text = "Email";
                }
            }
            else
            {
                lbl_Password_Or_PinCode.Text = "Pin Code";

                if (!cb_Login_Email.Checked)
                {
                    lbl_Email_or_AccNum_or_UserName.Text = "Account Number";
                }
                else
                {
                    lbl_Email_or_AccNum_or_UserName.Text = "Email";
                }
            }
        }

        private void cb_Login_as_user_CheckedChanged(object sender, EventArgs e)
        {
            change_login_requrments();
        }

        private void cb_Login_Email_CheckedChanged(object sender, EventArgs e)
        {
            change_login_requrments();
        }

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            startScreen.open_child_window(new ucCreateAccount(startScreen));
        }
    }
}
