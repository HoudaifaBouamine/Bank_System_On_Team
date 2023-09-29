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
        public clsPagesControler(Panel Container,Dictionary<string,Form> forms)
        {
            Forms = forms;
        }

        public void open_page(string FormName)
        {
            Forms[FormName].BringToFront();
            Forms[FormName].Select();
        }
    }
}
