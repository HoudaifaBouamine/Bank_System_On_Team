using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Bank_Business_Layer
{

    public class clsClient : clsPerson
    {

        /// <summary>
        /// Finds a client based on their unique Client ID and retrieves their information from the data source.
        /// </summary>
        /// <param name="Client_ID">The unique identifier of the client to find.</param>
        /// <returns>
        /// A <see cref="clsClient"/> object containing the client's information if found; otherwise, returns null.
        /// </returns>
        /// <remarks>
        /// This method queries the data source to locate a client using the specified Client ID. If a matching client
        /// is found, their details are retrieved and returned as a <see cref="clsClient"/> object. If no client is found
        /// with the provided Client ID, the method returns null.
        /// </remarks>
        public static clsClient Find(int Client_ID)
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

        public static clsClient Find(string Email)
        {
            int Person_ID = -1,Client_ID = -1;
            string AccountNumber = "", PinCode = "", Phone = "", FirstName = "", LastName = "", Country = "", City = "", Street = "";
            double Balance = 0;

            clsClient client = null;

            if (clsDataAccessLayer.Find_Client_By_Email(
                Email,ref Client_ID, ref Person_ID, ref AccountNumber, ref FirstName, ref LastName, ref Country, ref City, ref Street, ref PinCode, ref Phone, ref Balance))
            {
                client = new clsClient(Client_ID, Person_ID, AccountNumber, FirstName, LastName, Country, City, Street, Email, PinCode, Phone, Balance);
            }
            else
            {
                client = null;
            }

            return client;
        }


        public static clsClient Find_AccNum(string AccNum)
        {
            int Person_ID = -1, Client_ID = -1;
            string  PinCode = "", Phone = "", FirstName = "", LastName = "", Country = "", City = "", Street = "", Email = "";
            double Balance = 0;

            clsClient client = null;

            if 
                (
                    clsDataAccessLayer.Find_Client_By_AccountNumber
                    (
                        AccNum, ref Client_ID, ref Person_ID, ref FirstName, ref LastName,
                        ref Country, ref City, ref Street,ref Email, ref PinCode, ref Phone, ref Balance
                    )
                )
            {
                client = new clsClient(Client_ID, Person_ID, AccNum, FirstName, LastName,
                                       Country, City, Street, Email, PinCode, Phone, Balance);
            }
            else
            {
                client = null;
            }

            return client;
        }


        /// <summary>
        /// Deletes a client based on their unique Client ID from the data source.
        /// </summary>
        /// <param name="Client_ID">The unique identifier of the client to delete.</param>
        /// <returns>
        /// True if the client was successfully deleted; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method attempts to delete a client from the data source using the specified Client ID. If the deletion is
        /// successful, it returns true. If the deletion fails or the client with the provided Client ID does not exist,
        /// it returns false.
        /// </remarks>
        public static bool Delete(int Client_ID)
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

        /// <summary>
        /// Saves the current state of the client object to the data source based on its mode.
        /// </summary>
        /// <returns>
        /// True if the client data was successfully saved; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method is responsible for saving the current state of the client object to the data source based on its mode.
        /// If the client object is initialized using the default constructor <see cref="clsClient()"/>, it operates in 'eAddNew'
        /// mode, attempting to add a new client to the data source. If the client object is obtained using the <see cref="clsClient.Find(int)"/>
        /// function, it operates in 'eUpdate' mode, attempting to update an existing client's information. Returns true if the operation
        /// is successful, and false otherwise.
        /// </remarks>
        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.eAddNew:
                    {
                        return _Add_New_Client();
                    }

                case enMode.eUpdate:
                    {
                        return _Update_Client();
                    }

                default:
                    {
                        return false;
                    }
            }


            bool _Add_New_Client()
            {
                int client_id=-1, perons_id = -1;
                bool isAdded = clsDataAccessLayer.Add_New_Client_By_ID(ref client_id,ref perons_id, AccountNumber,FirstName,LastName,Country,City,Street, Email, PinCode,Phone, Balance);

                if (isAdded)
                {
                    this.Mode = enMode.eUpdate;
                    this.Client_ID = client_id;
                    this.Person_ID = perons_id;

                    return true;
                }
                else
                {
                    return false;
                }

            }

            bool _Update_Client()
            {
                return clsDataAccessLayer.Update_Client_By_ID(Client_ID, Person_ID, AccountNumber, FirstName, LastName, Country, City, Street, Email, PinCode,Phone,Balance);
            }
        }

        static public DataTable Table()
        {
            return clsDataAccessLayer.Get_Clients_List();
        }


        public bool Deposit(double amount)
        {
            if(Mode == enMode.eAddNew)
            {
                return false;
            }

            Balance += amount;



            return Save();
        }

        public bool Withdrawal(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public clsTransaction Transfer(clsClient receiver,double amount)
        {

            if (receiver == null) return null;

            if (this.Balance < amount) return null;

            clsTransaction TransferTransaction = new clsTransaction
                (clsTransaction.enTransaction.eTransfer, this.Client_ID, receiver.Client_ID, -1,
                Convert.ToInt16(clsTransaction.enTransaction.eTransfer), amount, DateTime.Now);
            
            this.Balance -= amount;
            receiver.Balance += amount;


            this.Save();
            receiver.Save();
            TransferTransaction.Save();

            return TransferTransaction;
        }
        static public DataTable Transactions_List(int Client_ID)
        {
            return clsDataAccessLayer.Get_Transaction_List_Client_ID(Client_ID);
        }

        public DataTable Transactions_List()
        {

            return Transactions_List(this.Client_ID);
        }

        public void SendEmail(string Subject,string Body)
        {
            clsMailManager.Send(this.Email, Subject, Body);
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
