using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Layer
{
    public class clsDataAccessSettings
    {

        private static string _ConnectionString = "Data Source = SQL8006.site4now.net; Initial Catalog = db_a9ee0f_banksystem; User Id = db_a9ee0f_banksystem_admin; Password=bank.houdaifa@321";

        //private static string _ConnectionString = "Data Source=.;Initial Catalog=BankSystem;User Id=DESKTOP-OCJUBFL\\houda;Password=sa123456";
        public static string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
        }
    
    }
}
