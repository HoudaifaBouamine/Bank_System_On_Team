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
using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen;
using System.Runtime.CompilerServices;

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
            

            if (!cb_Login_Email.Checked)
            {
                lbl_Email_or_AccNum_or_UserName.Text = "Account Number";
            }
            else
            {
                lbl_Email_or_AccNum_or_UserName.Text = "Email";
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

        private async void btn_SignUp_Click(object sender, EventArgs e)
        {

            await _Login();

        }

        private async Task _Login()
        {
            

                if (cb_Login_Email.Checked)
                {
                    ClientLoginEmail();
                }
                else
                {
                    await ClientLoginAccNum();
                }
            

            #region Client

            void ClientLoginEmail()
            {

                string Email = tb_Email_or_AccNum_or_UserName.Text;
                clsClient client = clsClient.Find(Email);

                if (client != null)
                {
                    string pincode = tb_Pass_Or_PinCode.Text;

                    if (client.PinCode == pincode)
                    {
                        //MessageBox.Show($"Client Login Success\nFull Name : {client.FirstName} {client.LastName}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        startScreen.mainForm.OpenChildForm(new frm_ClientScreen(startScreen.mainForm, client));
                    }
                    else
                    {
                        MessageBox.Show("Login Failed , client Pincode wrong", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed , client email Not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                // Code
            }

            Task ClientLoginAccNum()
            {

                string AccountNumber = tb_Email_or_AccNum_or_UserName.Text;
                clsClient client = clsClient.Find_AccNum(AccountNumber);

                if (client != null)
                {
                    string pincode = tb_Pass_Or_PinCode.Text;

                    if (client.PinCode == pincode)
                    {
                        //MessageBox.Show($"Client Login Success\nFull Name : {client.FirstName} {client.LastName}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        startScreen.mainForm.OpenChildForm(new frm_ClientScreen(startScreen.mainForm, client));

                    }
                    else
                    {
                        MessageBox.Show("Login Failed , client Pincode wrong", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed , client account number Not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return Task.CompletedTask;
            }

            #endregion
        }
    }
}
