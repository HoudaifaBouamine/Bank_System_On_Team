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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientScreen : Form
    {

        frm_MainForm mainForm = null;
        clsClient client;
        public frm_ClientScreen(frm_MainForm mainForm, clsClient client)
        {
            this.mainForm = mainForm;
            this.client = client;
            InitializeComponent();
            init_Screen();


            open_chiled_form(new frm_ClientHome(this, client));
            //open_chiled_form(new frm_ClientHistorique(client));
            //open_chiled_form(new frm_ClientSettings(this,client));
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
        }

        public void set_client_name()
        {
            lbl_ClientFullName.Text = client.FirstName + " " + client.LastName;
        }
        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            open_chiled_form(new frm_ClientHome(this, client));
        }

        private void btn_Settings_Click_1(object sender, EventArgs e)
        {
            open_chiled_form(new frm_ClientSettings(this, client));

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
            open_chiled_form(new frm_ClientHistorique(client));
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are sure you want to logout ?", "Logout confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.No) return;

            frm_StartScreen frm = new frm_StartScreen(mainForm);
            frm.open_child_window(new ucLogin(frm));

            mainForm.OpenChildForm(frm);

        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_ClientScreen_Load(object sender, EventArgs e)
        {
//            timer_Start_Refreaching_Client_Info.Start();

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
