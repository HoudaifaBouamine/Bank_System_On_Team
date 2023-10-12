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
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;

namespace Bank_Presentation_Layer_Windows_App
{
    public partial class frm_MainForm : Form
    {
        public frm_MainForm()
        {
            InitializeComponent();

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

            

            //ConnectToDataBase();
            await ConnectToDataBase();
            //OpenChildForm(new frm_ClientScreen(this, clsClient.Find(17)));
            OpenChildForm(new frm_StartScreen(this));


             Task ConnectToDataBase()
             {
                clsClient.Find(0);
                return Task.CompletedTask;
             }
            
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
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_MainForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
