﻿using Bank_Presentation_Layer_Windows_App.ClientLoginScreen;
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

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

            if (cb_Login_as_user.Checked)
            {
                if(cb_Login_Email.Checked)
                {
                    UserLoginEmail();
                }
                else
                {

                }
            }
            else
            {
                if (cb_Login_Email.Checked)
                {

                }
                else
                {

                }
            }

            #region User

            void UserLoginEmail()
            {
                string Email = tb_Email_or_AccNum_or_UserName.Text;
                clsUser user = clsUser.Find(Email);

                if(user != null)
                {
                    string password = tb_Pass_Or_PinCode.Text;

                    if(user.Password == password)
                    {
                        MessageBox.Show($"Login Success\nFull Name : {user.FirstName} {user.LastName}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show( "Login Failed , Password wrong","Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show( "Login Failed , Email Not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            #endregion

        }
    }
}
