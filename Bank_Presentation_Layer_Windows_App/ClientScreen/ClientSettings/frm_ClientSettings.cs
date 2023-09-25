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
        public frm_ClientSettings(clsClient client)
        {
            this.client = client;
            InitializeComponent();
            Load_Client_Info();
        }

        private void Load_Client_Info()
        {
            tb_AccountNumber.Text = client.AccountNumber;
            tb_Balance.Text = client.Balance.ToString();

            tb_FirstName.Text = client.FirstName;
            tb_LastName.Text = client.LastName;
            tb_Country.Text = client.Country;
            tb_City.Text = client.City;
            tb_Street.Text = client.Street;

            tb_Email.Text = client.Email;
            tb_Phone.Text = client.Phone;
        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_ClientSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
