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

namespace Bank_Presentation_Layer_Windows_App.ClientScreen
{
    public partial class frm_ClientScreen : Form
    {

        frm_MainForm mainForm = null;
        public frm_ClientScreen(frm_MainForm mainForm,clsClient client)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
    }
}
