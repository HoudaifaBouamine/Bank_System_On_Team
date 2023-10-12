using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank_Presentation_Layer_Windows_App.Util
{
    internal class clsPagesControler
    {
        Dictionary<string, Form> Forms;
        public clsPagesControler(Panel Container, Dictionary<string, Form> forms)
        {
            Forms = forms;

            foreach (var form in Forms)
            { 
                Container.Controls.Add(form.Value);
                form.Value.Dock = DockStyle.Fill;
            }
        }

        public void open_page(string FormName)
        {


            foreach (var form in Forms)
            {
                form.Value.Visible = false;
            }

            Forms[FormName].Visible = true;
            Forms[FormName].BringToFront();
            Forms[FormName].Activate();


        }
    }
}
