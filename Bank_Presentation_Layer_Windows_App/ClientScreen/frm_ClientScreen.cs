using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientSettings;
using Bank_Presentation_Layer_Windows_App.ClientStartScreen;
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
using Zeroit.Framework.LineSeparators;
using System.Threading;
using System.Xml;
using Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer;
using Bank_Presentation_Layer_Windows_App.Util;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientScreen : frm_MainBaseForm
    {

        frm_MainForm mainForm = null;
        clsClient client;


        Dictionary<string, Form> forms = new Dictionary<string, Form>();

        public frm_ClientScreen(frm_MainForm mainForm, clsClient client)
        {
            this.mainForm = mainForm;
            this.client = client;

            InitializeComponent();
            init_Screen();

            forms.Add("Home", new frm_ClientHome(this,client));
            forms.Add("Historique", new frm_ClientHistorique(client));
            forms.Add("Settings", new frm_ClientSettings(this,client));

            controler = new clsPagesControler(pnl_Main, forms);
            SelectButton(btn_Home);
        }

       

        void RefrechTheClientInfo()
        {
            while (true)
            {
                client.Refresh();
                Thread.Sleep(1000);
            }
        }

        private void init_Screen()
        {
            set_client_name();

            draw_line(pnl_Seperator1);
            draw_line(pnl_Seperator2);


            void draw_line(Panel sep)
            {
                ZeroitChromeLine line = new ZeroitChromeLine();
                line.Width = 260;
                line.Location = new Point(40, sep.Height / 2 - line.Height / 2);


                sep.Controls.Add(line);
            }

            btn_Historique.Tag = "NOT_SELECTED";
            btn_Settings.Tag = "NOT_SELECTED";
            btn_Logout.Tag = "NOT_SELECTED";
            btn_Home.Tag = "SELECTED";
        }

        public void set_client_name()
        {
            lbl_ClientFullName.Text = client.FirstName + " " + client.LastName;
        }

        Button _LastButtonClicked = null;
        private void SelectButton(Button btn)
        {

            if (btn_Historique.Tag.ToString() == "SELECTED")
            {
                btn_Historique.Tag = "NOT_SELECTED";
                btn_Historique.BackColor = Color.FromArgb(17, 45, 78);
                _LastButtonClicked = btn_Historique;
            }
            else if (btn_Home.Tag.ToString() == "SELECTED")
            {
                btn_Home.Tag = "NOT_SELECTED";
                btn_Home.BackColor = Color.FromArgb(17, 45, 78);                _LastButtonClicked = btn_Historique;
                _LastButtonClicked = btn_Home;

            }
            else if (btn_Settings.Tag.ToString() == "SELECTED")
            {
                btn_Settings.Tag = "NOT_SELECTED";
                btn_Settings.BackColor = Color.FromArgb(17, 45, 78);
                _LastButtonClicked = btn_Settings;

            }
            else if (btn_Logout.Tag.ToString() == "SELECTED")
            {
                btn_Logout.Tag = "NOT_SELECTED";
                btn_Logout.BackColor = Color.FromArgb(17, 45, 78);
                _LastButtonClicked = btn_Logout;

            }


            btn.Tag = "SELECTED";
            btn.BackColor = Color.FromArgb(35, 67, 115);

        }
        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            controler.open_page("Home");
            SelectButton((Button)sender);
        }

        private void btn_Settings_Click_1(object sender, EventArgs e)
        {
            controler.open_page("Settings");
            SelectButton((Button)sender);

        }

        public Form currentActivateForm = null;
        public void open_chiled_form(Form form)
        {
            Form prevForm = null;

            if (currentActivateForm != null)
            {
                if (form == currentActivateForm)
                {
                    return;
                }

                prevForm = currentActivateForm;
            }
            currentActivateForm = form;

            currentActivateForm.TopLevel = false;
            pnl_Main.Controls.Add(currentActivateForm);
            currentActivateForm.Dock = DockStyle.Fill;
            currentActivateForm.BringToFront();
            currentActivateForm.Show();
            currentActivateForm.Activate();

            if (prevForm != null)
            {
                pnl_Main.Controls.Remove(prevForm);
            }

        }

        private void btn_Historique_Click_1(object sender, EventArgs e)
        {
            controler.open_page("Historique");
            SelectButton((Button)sender);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {


            SelectButton((Button)sender);
            DialogResult result = MessageBox.Show("Are sure you want to logout ?", "Logout confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.No) {

                SelectButton(_LastButtonClicked);
                return;
                    
            }

            frm_StartScreen frm = new frm_StartScreen(mainForm);
            frm.open_child_window(new ucLogin(frm));

            mainForm.OpenChildForm(frm);

        }

        private void frm_ClientScreen_Load(object sender, EventArgs e)
        {
            controler.open_page("Home");

        }

        bool isFirst = true;
        private void timer_Start_Refreaching_Client_Info_Tick(object sender, EventArgs e)
        {

            if (!isFirst)
            {
                Thread RefrechingTread = new Thread(() => RefrechTheClientInfo());
                RefrechingTread.Start();

                timer_Start_Refreaching_Client_Info.Stop();

            }
            else
            {
                isFirst = false;
            }
        }
    }
}

