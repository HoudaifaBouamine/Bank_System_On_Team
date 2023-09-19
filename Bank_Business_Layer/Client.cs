using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;
using System.Security.Cryptography;

namespace Bank_Business_Layer
{

    public class clsClient : clsPerson
    {

        public static clsClient find(int Client_ID)
        {
            int Person_ID = -1;
            string AccountNumber = "", Email = "", PinCode = "", Phone = "", FirstName="",LastName ="",Country="",City="",Street="";
            double Balance = 0;

            clsClient client = null;

            if (clsDataAccessLayer.Find_Client_By_ID(
                Client_ID, ref Person_ID, ref AccountNumber,ref FirstName,ref LastName,ref Country,ref City,ref Street, ref Email, ref PinCode, ref Phone, ref Balance))
            {
                client = new clsClient(Client_ID,Person_ID, AccountNumber,FirstName,LastName,Country,City,Street, Email, PinCode, Phone, Balance);
            }
            else
            {
                client = null;
            }

            return client;
        }
    
        public static bool delete(int Client_ID)
        {
            if(clsDataAccessLayer.Delete_Client_By_ID(Client_ID))
            {
                // NOTE (HOUDAIFA) : I know this look stupid , but how know when I need to debug it ? (Houdaifa ,fix this later)
                return true;
            }
            else
            {
                return false;
            }
        }
















        public int Client_ID { get; private set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public double Balance { get; set; }
        private enMode Mode { get; set; }

        public clsClient() : base()
        {
            Mode = enMode.eAddNew;

            this.Client_ID = -1;
            this.AccountNumber = "";
            this.Email = "";
            this.PinCode = "";
            this.Phone = "";
            this.Balance = 0;
        }

        private clsClient(int Client_ID, int Person_ID, string AccountNumber, string FirstName,string LastName,string Country,string City,string Street, string Email, string PinCode, string Phone, double Balance) : base(Person_ID,FirstName,LastName,Country,City,Street)
        { 

            Mode = enMode.eUpdate;

            this.Client_ID = Client_ID;
            this.AccountNumber = AccountNumber;
            this.Email = Email;
            this.PinCode = PinCode;
            this.Phone = Phone;
            this.Balance = Balance;
        }

        private enum enMode { eAddNew,eUpdate};
    }

}
