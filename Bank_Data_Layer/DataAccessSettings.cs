using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Layer
{
    public class clsDataAccessSettings
    {

        private static string _ConnectionString = "Server=sql.bsite.net\\MSSQL2016;Database=banksystem_DataBase;User Id=banksystem_DataBase;Password=dbBankSystemPassword1234567890;";
    
        public static string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
        }
    
    }
}
