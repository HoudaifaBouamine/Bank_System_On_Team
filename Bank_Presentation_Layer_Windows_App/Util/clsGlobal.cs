using Bank_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Presentation_Layer_Windows_App
{
    public static class clsGlobal
    {
        public enum enPage { Client_Home, Client_Historique, Client_Settings };
        static public Dictionary<enPage, bool> Refrech { get; set; } = new Dictionary<enPage, bool>() 
        {
            { enPage.Client_Home       , false },
            { enPage.Client_Historique , false },
            { enPage.Client_Settings   , false },

        };

        static public bool NeedToRefrech 
        {
            get
            {

                return Refrech[enPage.Client_Home] 
                    || Refrech[enPage.Client_Historique]
                    || Refrech[enPage.Client_Settings];

            }
            set 
            {
               
                Refrech[enPage.Client_Home] = value;
                Refrech[enPage.Client_Historique] = value;
                Refrech[enPage.Client_Settings] = value;
              
            }
        }

      
    }

}
