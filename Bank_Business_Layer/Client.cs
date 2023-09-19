using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;

namespace Bank_Business_Layer
{

    public class clsClient : clsPerson
    { 



        public int Client_ID { get; private set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
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

        private clsClient(int Client_ID, int Person_ID, string AccountNumber, string FirstName,string LastName,string Country,string City,string Street, string Email, string PinCode, string Phone, decimal Balance) : base(Person_ID,FirstName,LastName,Country,City,Street)
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
