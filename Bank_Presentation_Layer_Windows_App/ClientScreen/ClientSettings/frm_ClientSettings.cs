using Bank_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientSettings
{
    public partial class frm_ClientSettings : Form
    {

        clsClient client=null;
        frm_ClientScreen clientScreen = null;
        public frm_ClientSettings(frm_ClientScreen clientScreen,clsClient client)
        {
            this.client = client;
            this.clientScreen = clientScreen;
            InitializeComponent();
            init_Settings();


            TopLevel = false;
        }

        public void init_Settings()
        {

            tb_AccountNumber.Text = client.AccountNumber;
            tb_Balance.Text = string.Format("{0:0.00}", client.Balance) + " $";

            tb_FirstName.Text = client.FirstName;
            tb_LastName.Text = client.LastName;
            tb_Country.Text = client.Country;
            tb_City.Text = client.City;
            tb_Street.Text = client.Street;

            tb_Email.Text = client.Email;
            tb_Phone.Text = client.Phone;
        }


        private void btn_SaveClientInfo_Click(object sender, EventArgs e)
        {

            if (!Check_Change())
            {
                MessageBox.Show("You did not change any of your information\nthere is nothing to save","Nothing Changed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SavingChanges();
            }

        }

        private void SavingChanges()
        {
            DialogResult result = MessageBox.Show("Are You sure you want to save this changes ?", "Change confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;
            
            
            client.FirstName = tb_FirstName.Text;
            client.LastName  = tb_LastName.Text ;
            client.Country   = tb_Country.Text ;
            client.City      = tb_City.Text ;
            client.Street    = tb_Street.Text;

            client.Email     = tb_Email.Text;
            client.Phone     = tb_Phone.Text;
            
            client.Save();
            

            clientScreen.lbl_ClientFullName.Text = client.FirstName + " " + client.LastName;
        }

        private bool Check_Change()
        {
            bool thereIsChange = false;

            thereIsChange = thereIsChange || (tb_FirstName.Text != client.FirstName);
            thereIsChange = thereIsChange || (tb_LastName.Text != client.LastName);
            thereIsChange = thereIsChange || (tb_Country.Text != client.Country);
            thereIsChange = thereIsChange || (tb_City.Text != client.City);
            thereIsChange = thereIsChange || (tb_Street.Text != client.Street);
            thereIsChange = thereIsChange || (tb_Email.Text != client.Email);
            thereIsChange = thereIsChange || (tb_Phone.Text != client.Phone);

            return thereIsChange;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            init_Settings();
        }

        private void frm_ClientSettings_Paint(object sender, PaintEventArgs e)
        {
            if (clsGlobal.Refrech[clsGlobal.enPage.Client_Settings])
            {
                init_Settings();
                clsGlobal.Refrech[clsGlobal.enPage.Client_Settings] = false;
            }
        }



        private void tb_Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_ClientSettings_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChangePinCode_Click(object sender, EventArgs e)
        {
            pnl_ChangePinCodeChoice.Visible = false;
            pnl_ChangePinCodeScreen.Visible = true;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            string PinCode = tb_PinCode.Text.Trim();

            if(tb_NewPinCode.Text.Trim() != tb_NewPinCodeRewrite.Text.Trim())
            {
                MessageBox.Show("Pin Codes are not identical", "New Pin Code is not the same of the second Pin Code you entred, Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_PinCode.Text = "";
                return;
            }

            if (PinCode != client.PinCode)
            {
                MessageBox.Show("Wrong Pin Code", "Pin Code is Wrong, Try again",MessageBoxButtons.OK,MessageBoxIcon.Error);

                tb_PinCode.Text = "";
                tb_NewPinCode.Text = "";
                tb_NewPinCodeRewrite.Text = "";
                return;
            }

            client.PinCode = tb_NewPinCode.Text.Trim();

            if (client.Save())
            {
                MessageBox.Show("Your Pin Code Changed Successfuly", "Pin Code Saved Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_PinCode.Text = "";
                tb_NewPinCode.Text = "";
                tb_NewPinCodeRewrite.Text = "";
                pnl_ChangePinCodeScreen.Visible = false;
                pnl_ChangePinCodeChoice.Visible = true;
                btn_Save.Enabled = true;
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong When tring to save your new Pin Code", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void tb_PinCode_TextChanged(object sender, EventArgs e)
        {
            string s= tb_PinCode.Text + tb_NewPinCode.Text + tb_NewPinCodeRewrite.Text;

            if(s == "")
            {
                btn_Save.Enabled = true;
            }
            else
            {
                btn_Save.Enabled=false;
            }
        }
    }
}
