using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Business_Layer;
using Bank_Data_Layer;
using System.IO;
using System.Security.Policy;
using System.Net;
using System.Data.SqlClient;

namespace Bank_Presentation_Layer_Consol_App
{
    internal class Program
    {

        static void execute_query(string query)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand Command = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                Command.ExecuteNonQuery();

                Console.WriteLine("Query Done Successfuly\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong, Query not done succssfuly\n");

            }
            finally
            {
                connection.Close();
            }
        }
        static void Main(string[] args)
        {

            execute_query("Create View Transaction_Details_View as ( select  Transactions.* , User_Person_List_View.Person_ID as UserPerson_ID , UserName,User_Person_List_View.Email as UserEmail, User_Person_List_View.Password as UserPassword,User_Person_List_View.Phone as UserPhone,Permission,User_Person_List_View.FirstName as UserFirstName,User_Person_List_View.LastName as UserLastName, User_Person_List_View.Country as UserCountry,User_Person_List_View.City as UserCity,User_Person_List_View.Street as UserStreet,Receiver.Person_ID as ReceiverPerson_ID,Receiver.AccountNumber as ReceiverAccountNumber,Receiver.Email as ReceiverEmail,Receiver.PinCode as ReceiverPinCode,Receiver.Phone as ReceiverPhone,Receiver.Balance as ReceiverBalance,Receiver.FirstName as ReceiverFirstName,Receiver.LastName as ReceiverLastName,Receiver.Country as ReceiverCountry,Receiver.City as ReceiverCity,Receiver.Street as ReceiverStreet,Sender.Person_ID as SenderPerson_ID,Sender.AccountNumber as SenderAccountNumber,Sender.Email as SenderEmail,Sender.PinCode as SenderPinCode,Sender.Phone as SenderPhone,Sender.Balance as SenderBalance,Sender.FirstName as SenderFirstName,Sender.LastName as SenderLastName,Sender.Country as SenderCountry,Sender.City as SenderCity,Sender.Street as SenderStreet from  Transactions  Left join  User_Person_List_View ON User_Person_List_View.User_ID = Transactions.User_ID Left join  Client_Person_List_View Receiver ON Receiver.Client_ID = Transactions.Receiver_ID Left join  Client_Person_List_View Sender ON Sender.Client_ID = Transactions.Sender_ID ) ");

            //test.Print_Clients_List();

            Console.ReadKey();
        }

    }




    class test
    {

        public static void print_user(clsUser user)
        {

            Console.WriteLine($"===============================");
            Console.WriteLine($"=      User Info              =");
            Console.WriteLine($"===============================");
            Console.WriteLine($" User_ID    : {user.User_ID}");
            Console.WriteLine($" Person_ID  : {user.Person_ID}");
            Console.WriteLine($" UserName  : {user.UserName}");
            Console.WriteLine($" FirstName  : {user.FirstName}");
            Console.WriteLine($" LastName   : {user.LastName}");
            Console.WriteLine($" Country    : {user.Country}");
            Console.WriteLine($" City       : {user.City}");
            Console.WriteLine($" Street     : {user.Street}");
            Console.WriteLine($" Email      : {user.Email}");
            Console.WriteLine($" Password   : {user.Password}");
            Console.WriteLine($" Phone      : {user.Phone}");
            Console.WriteLine($" Permission : {user.Permission}");
            Console.WriteLine($"===============================\n\n");
        }
        public static void find_user(int id)
        {

            clsUser user = clsUser.Find(id);

            if (user == null)
            {
                Console.WriteLine($"User [{id}] Not Found\n\n");
            }
            else
            {
                print_user(user);
            }
        }

        public static void update_user_phone(int id, string phone)
        {
            clsUser user = clsUser.Find(id);

            if (user != null)
            {
                user.Phone = phone;

                if (!user.Save())
                {
                    Console.WriteLine("Error, Con not save \n\n\n");
                }
            }
        }

        public static void add_new_user()
        {
            clsUser new_user = new clsUser();


            new_user.FirstName = "Houdaifa";
            new_user.LastName = "Bouamine";
            new_user.UserName = "Admin";
            new_user.Country = "Algeria";
            new_user.City = "Souk-Ahras";
            new_user.Street = "Home";
            new_user.Email = "houdaifa@gmail.com";
            new_user.Password = "password123";
            new_user.Phone = "0987654321";
            new_user.Permission = -1;

            if (new_user.Save())
            {
                Console.WriteLine($"User saved succssfuly with id = {new_user.User_ID}");
            }
            else
            {
                Console.WriteLine("User Failed to add");
            }
        }

        public static void print_users_list()
        {
            DataTable list_users = clsUser.list();

            if (list_users.Rows.Count < 1)
            {
                Console.WriteLine("Empty list");
            }

            foreach (DataRow user in list_users.Rows) print_user(new clsUser(user));
        }




        static public void Print_user_list_as_table()
        {
            DataTable list_users = clsUser.list();

            if (list_users.Rows.Count < 1)
            {
                Console.WriteLine("Empty list");
            }



            foreach (DataRow user in list_users.Rows)
            {
                Console.WriteLine($"{user["User_ID"],-6} | {user["UserName"],-15} | {user["FirstName"],-15} | {user["LastName"],-15} | {user["Permission"],-5}");
            }

        }
        static void delete_user(int id)
        {
            clsUser user = clsUser.Find(id);

            if (user == null)
            {

                Console.WriteLine("\n\nUser not found\n\n");
            }

            else
            {
                print_user(user);


                Console.WriteLine("Are you sure to delete this user ?[y/n] >> ");
                char yes_or_no = 'n';
                yes_or_no = Console.ReadLine()[0];

                if (yes_or_no == 'y')
                {
                    if (clsUser.Delete(user.User_ID))
                    {
                        Console.WriteLine("\n\nUser Deleted Successfuly\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\nFailed To delete user\n\n");
                    }
                }
            }

        }





        public static void print_client(clsClient client)
        {

            Console.WriteLine($"===============================");
            Console.WriteLine($"=      User Info              =");
            Console.WriteLine($"===============================");
            Console.WriteLine($" Client_ID  : {client.Client_ID}");
            Console.WriteLine($" Person_ID  : {client.Person_ID}");
            Console.WriteLine($" Acc Num    : {client.AccountNumber}");
            Console.WriteLine($" FirstName  : {client.FirstName}");
            Console.WriteLine($" LastName   : {client.LastName}");
            Console.WriteLine($" Country    : {client.Country}");
            Console.WriteLine($" City       : {client.City}");
            Console.WriteLine($" Street     : {client.Street}");
            Console.WriteLine($" Email      : {client.Email}");
            Console.WriteLine($" Pin Code   : {client.PinCode}");
            Console.WriteLine($" Phone      : {client.Phone}");
            Console.WriteLine($" Balance    : {client.Balance}");
            Console.WriteLine($"===============================\n\n");
        }

        public static bool find_client(int Client_ID)
        {
            clsClient client = clsClient.Find(Client_ID);

            if (client == null)
            {
                Console.WriteLine("Client Not FOund\n\n");
                return false;
            }
            else
            {
                print_client(client);
                return true;
            }
        }

        public static void delete_client(int id)
        {
            if (find_client(id))
            {
                Console.Write("Are you sure to delete this client ? [y/n] >> ");
                char yes = Console.ReadLine()[0];

                if (yes == 'y')
                {
                    clsClient.Delete(id);
                }

            }
        }

        public static void update_client(int id)
        {
            clsClient client = clsClient.Find(id);

            if (client != null)
            {
                Console.WriteLine("Client before update :\n");
                print_client(client);

                client.FirstName = "Mohammed";
                client.LastName = "Riad";
                client.Email = "m.riad@gmail.com";

                if (client.Save())
                {
                    Console.WriteLine("\nClient updated successfuly\n\n");
                    Console.WriteLine("Client after update :\n");
                    print_client(client);
                }
                else
                {
                    Console.WriteLine("\nFailed to update client\n\n");
                }
            }
            else
            {
                Console.WriteLine("\nFailed to find client\n\n");
            }
        }

        public static void add_new_client()
        {
            clsClient new_client = new clsClient();


            new_client.FirstName = "Ishaq";
            new_client.LastName = "Ishaq";
            new_client.AccountNumber = "A001";
            new_client.Country = "Algeria";
            new_client.City = "Sidi-Bel-Abess";
            new_client.Street = "Home";
            new_client.Email = "i.ishaq@gmail.com";
            new_client.PinCode = "0000";
            new_client.Phone = "0123456788";
            new_client.Balance = 123456789.123456789;

            if (new_client.Save())
            {
                Console.WriteLine($"User saved succssfuly with id = {new_client.Client_ID}");
            }
            else
            {
                Console.WriteLine("User Failed to add");
            }
        }

        public static void Print_Clients_List()
        {

            DataTable dataTable = clsClient.Table();

            Console.WriteLine("List of Clients:");
            Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-15} {4,-15}", "Client_ID", "FirstName", "LastName", "AccountNumber", "Phone");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-15} {4,-15}",
                    row["Client_ID"], row["FirstName"], row["LastName"], row["AccountNumber"], row["Phone"]);
            }
        }


        public static void transaction_list()
        {


            DataTable trans_list = clsTransaction.Table();

            if (trans_list.Rows.Count < 1)
            {
                Console.WriteLine("Empty list");
            }



            foreach (DataRow trans in trans_list.Rows)
            {
                Console.WriteLine($"{trans["Transaction_ID"],-6} | {trans["Sender_ID"],-15} | {trans["Receiver_ID"],-15} | {trans["User_ID"],-15} | {trans["Amount"],-5}");
            }
        }

        public static void PrintTransactionsTable()
        {
            List<clsTransaction> transactions = clsTransaction.List();

            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions found.");
            }
            else
            {
                // Print table header
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-25} {4,-15} {5,-15} {6,-15}",
                    "Transaction ID", "Transaction Type ID", "Amount", "Transaction Date Time", "Sender", "Receiver", "User");

                foreach (var transaction in transactions)
                {
                    // Print transaction details
                    Console.WriteLine("{0,-15} {1,-15} {2,-15:C} {3,-25} {4,-15} {5,-15} {6,-15}",
                        transaction.Transaction_ID, transaction.TransactionType_ID, transaction.Amount,
                        transaction.TransactionDateTime, transaction.Sender?.AccountNumber ?? "N/A",
                        transaction.Receiver?.AccountNumber ?? "N/A", transaction.User?.UserName ?? "N/A");
                }
            }
        }
    }

}
