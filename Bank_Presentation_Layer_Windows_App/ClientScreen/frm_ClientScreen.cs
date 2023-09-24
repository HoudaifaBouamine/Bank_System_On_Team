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
using Zeroit.Framework.LineSeparators;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientScreen : Form
    {

        frm_MainForm mainForm = null;
        clsClient client;
        public frm_ClientScreen(frm_MainForm mainForm,clsClient client)
        {
            this.mainForm = mainForm;
            this.client = client;
            InitializeComponent();
            init_Screen();



            //open_chiled_form(new frm_ClientHome(client));
            open_chiled_form(new frm_ClientHistorique(client));
        }

        private void init_Screen()
        {
            lbl_ClientFullName.Text = client.FirstName + " " + client.LastName;

            draw_line(pnl_Seperator1);
            draw_line(pnl_Seperator2);


            void draw_line(Panel sep)
            {
                ZeroitChromeLine line = new ZeroitChromeLine();
                line.Width = 260;
                line.Location = new Point(40, sep.Height/2 - line.Height/2);
                

                sep.Controls.Add(line);
            }
        }


        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            open_chiled_form(new frm_ClientHome(client));
        }

        private void btn_Settings_Click_1(object sender, EventArgs e)
        {
            open_chiled_form(new frm_ClientSettings(client));
        }

        Form currentActivateForm = null;
        private void open_chiled_form(Form form)
        {
            Form prevForm = null;

            if (currentActivateForm != null)
            {
                if(form == currentActivateForm)
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

            if(prevForm != null)
            {
                pnl_Main.Controls.Remove(prevForm);
            }

        }

        private void btn_Historique_Click_1(object sender, EventArgs e)
        {
            open_chiled_form(new frm_ClientHistorique(client));
        }
    }
}
