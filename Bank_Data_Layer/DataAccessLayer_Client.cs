using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Layer
{
    public partial class clsDataAccessLayer
    {

        /// <summary>
        /// Search on the Database for client by <c>Client_ID</c> and return the client info as variables using <c>ref</c> key word
        /// </summary>
        /// <param name="Client_ID"></param>
        /// <returns>return <c>true</c> if the Client found succssufuly, otherwise return <c>flase</c></returns>
        static public bool Find_Client_By_ID
            (
            int Client_ID, ref int Person_ID,ref string AccountNumber, ref string FirstName, ref string LastName,
            ref string Country, ref string City, ref string Street,
            ref string Email, ref string PinCode,
            ref string Phone, ref double Balance
            )

        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Persons.FirstName,Persons.LastName,Persons.Country,Persons.City,Persons.Street ,Clients.* from Clients Inner join Persons on Persons.Person_ID = Clients.Person_ID WHERE Clients.Client_ID = @Client_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Client_ID", Client_ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Person_ID = (int)reader["Person_ID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Country = (string)reader["Country"];
                    City = (string)reader["City"];
                    Street = (string)reader["Street"];
                    Email = (string)reader["Email"];
                    PinCode = (string)reader["PinCode"];
                    Phone = (string)reader["Phone"];
                    Balance = Convert.ToInt32( reader["Balance"]);


                    isFound = true;
                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
