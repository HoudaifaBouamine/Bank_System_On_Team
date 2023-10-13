using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Business_Layer;

namespace Bank_Presentation_Layer_User_Windows_App.Util
{
    public class clsGlobal
    {

        static private clsUser _CurrentUser = null;
        static public clsUser CurrentUser 
        {
            get
            {
                return _CurrentUser;
            }
            set
            {
                _CurrentUser = value;
            }
        }
    }
}
