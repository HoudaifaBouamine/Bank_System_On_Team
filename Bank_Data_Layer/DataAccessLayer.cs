using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Layer
{
    public class clsDataAccessLayer
    {

        static public bool Find_Client_By_ID
            (
            int Client_ID,ref int Person_ID,ref string FirstName,ref string LastName,
            ref string Country,ref string City,ref string Street,
            ref string Email,ref string Password,
            ref string Phone,ref double Balance
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

                if(reader.Read())
                {

                    Person_ID = (int)reader["Person_ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Country = (string)reader["Country"];
                    City = (string)reader["City"];
                    Street = (string)reader["Street"];
                    Email = (string)reader["Email"];
                    Password = (string)reader["Password"];
                    Phone = (string)reader["Phone"];
                    Balance = (double)reader["Balance"];


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

        static public bool Find_User_By_ID
            (
                int User_ID, ref int Person_ID, ref string FirstName, ref string LastName,
                ref string Country, ref string City, ref string Street,
                ref string Email, ref string Password,
                ref string Phone, ref int Permission
            )

        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Persons.FirstName,Persons.LastName,Persons.Country,Persons.City,Persons.Street ,Users.* from Users Inner join Persons on Persons.Person_ID = Users.Person_ID WHERE Users.[User_ID] = @User_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_ID", User_ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Person_ID = (int)reader["Person_ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Country = (string)reader["Country"];
                    City = (string)reader["City"];
                    Street = (string)reader["Street"];
                    Email = (string)reader["Email"];
                    Password = (string)reader["Password"];
                    Phone = (string)reader["Phone"];
                    Permission = (int)reader["Permission"];


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
