using Bank_Business_Layer;
using Bank_Presentation_Layer_User_Windows_App.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Bank_Presentation_Layer_User_Windows_App.Start
{
    public partial class frm_Login : Form
    {
        private frm_Login()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        static private frm_Login _Screen = null;
        static public frm_Login Screen
        {
            get
            {
                if (_Screen == null)
                {
                    _Screen = new frm_Login();
                }

                return _Screen;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            enLoginStatus LoginResult = _TryLoginEmail(tb_Email.Text.Trim(), tb_Password.Text.Trim());

            if (LoginResult == enLoginStatus.eSuccess)
            {
                // Login Code

            }
        }

        private enLoginStatus _TryLoginEmail(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return enLoginStatus.eEmailEmpty;
            }

            if (Password == "")
            {
                return enLoginStatus.ePasswordEmpty;
            }

            if (!isValidEmail(Email))
            {
                return enLoginStatus.eEmailNonValid;
            }

            if (Password.Length < 8)
            {
                return enLoginStatus.ePasswordSmallerThanMinLength;
            }

            clsUser user = clsUser.Find(Email);

            if (user == null)
            {
                return enLoginStatus.eFailedEmailNotFound;
            }

            if (user.Password != Password)
            {
                return enLoginStatus.eFailedPasswordWrong;
            }

            clsGlobal.CurrentUser = user;

            return enLoginStatus.eSuccess;
        }

        #region Validation


        private bool isValidEmail(string Email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(Email);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        #endregion
        private enum enLoginStatus { eSuccess, eFailedEmailNotFound, eFailedPasswordWrong, eEmailEmpty, eEmailNonValid, ePasswordEmpty, ePasswordSmallerThanMinLength };
    }
}
