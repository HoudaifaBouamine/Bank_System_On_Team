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
            string VerificationKey;
        public ucVerifyEmail(frm_StartScreen startScreen,clsClient client)
        {
            this.startScreen = startScreen;
            this.client = client;
            InitializeComponent();

            SendVerification();
        }

        private void SendVerification() 
        {
            VerificationKey = clsUtil.GenerateVerificationKey(6);

            string Subject = "Subject: Action Required: Email Verification";
            string Body = $"Dear {client.FirstName} {client.LastName}," +
                "\r\n\r\nTo secure your account," +
                " please enter the 6-digit verification key in your Houdaifa Bank app." +
                $"\r\n\r\nVerification Key: {VerificationKey}" +
                "\r\n\r\nThank you for choosing Houdaifa Bank." +
                "\r\n\r\nSincerely," +
                "\r\nEmail Verification Bot" +
                "\r\nHoudaifa Bank";

            this.client.SendEmail(Subject,Body);
        }

        private void btn_VerifyEmail_Click(object sender, EventArgs e)
        {
            string EnteredKey = tb_VerificationKey.Text.Trim();

            if(EnteredKey != VerificationKey)
            {
                MessageBox.Show("The key you entred is wrong","Wrong key",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            startScreen.open_child_window(new ucEnterPhoneNumber(startScreen,client));

        }
    }
}
