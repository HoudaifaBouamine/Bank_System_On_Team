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
    }
}
