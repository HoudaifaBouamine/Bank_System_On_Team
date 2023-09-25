using Bank_Business_Layer;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Transfer
{
    public partial class frm_TransferMainScreen : Form
    {
        clsClient client = null;
        public frm_TransferMainScreen(clsClient client)
        {
            this.client = client;
            InitializeComponent();
            open_chiled_form(new frm_TransferFirstScreen());
        }

        Form currentActivateForm = null;
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

        private void frm_TransferMainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
