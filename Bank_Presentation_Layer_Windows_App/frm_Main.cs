using Bank_Business_Layer;
using Bank_Presentation_Layer_Windows_App.ClientScreen;
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

namespace Bank_Presentation_Layer_Windows_App
{
    public partial class frm_MainForm : Form
    {
        public frm_MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ClientScreen(this, clsClient.Find(1)));
            //OpenChildForm(new frm_StartScreen(this));
        }

        Form currentActivateForm = null;
        public void OpenChildForm(Form form)
        {
            if(currentActivateForm != null) 
            {
                currentActivateForm.Close();
            }

            currentActivateForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
