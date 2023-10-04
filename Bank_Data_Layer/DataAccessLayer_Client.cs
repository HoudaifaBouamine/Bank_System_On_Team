using System;
using System.Collections.Generic;
using System.Data;
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

            string query = "select * from Client_Person_List_View WHERE Client_ID = @Client_ID";

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
                    Balance = Convert.ToDouble( reader["Balance"]);


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

        static public bool Find_Client_By_Email
           (
           string Email,ref int Client_ID, ref int Person_ID, ref string AccountNumber, ref string FirstName, ref string LastName,
           ref string Country, ref string City, ref string Street,
            ref string PinCode,
           ref string Phone, ref double Balance
           )

        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Client_Person_List_View WHERE Email = @Email";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Person_ID = (int)reader["Person_ID"];
                    Client_ID = (int)reader["Client_ID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Country = (string)reader["Country"];
                    City = (string)reader["City"];
                    Street = (string)reader["Street"];
                    PinCode = (string)reader["PinCode"];
                    Phone = (string)reader["Phone"];
                    Balance = Convert.ToDouble(reader["Balance"]);


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

        static public bool Find_Client_By_AccountNumber
            (
            string AccountNumber,ref int Client_ID, ref int Person_ID,  ref string FirstName, ref string LastName,
            ref string Country, ref string City, ref string Street,
            ref string Email, ref string PinCode,
            ref string Phone, ref double Balance
            )

        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Client_Person_List_View WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Person_ID = (int)reader["Person_ID"];
                    Client_ID = (int)reader["Client_ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Country = (string)reader["Country"];
                    City = (string)reader["City"];
                    Street = (string)reader["Street"];
                    Email = (string)reader["Email"];
                    PinCode = (string)reader["PinCode"];
                    Phone = (string)reader["Phone"];
                    Balance = Convert.ToDouble(reader["Balance"]);
                        

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

        static public bool Delete_Client_By_ID(int Client_ID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Persons WHERE Persons.Person_ID = (select Clients.Person_ID from Clients WHERE Clients.Client_ID = @Client_ID); DELETE FROM Clients WHERE Client_ID = @Client_ID; ";

            // NOTE (HOUDAIFA) : You have to modify this query to check if the Person is related to a user (because a person may be a client and a user at the same time)

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Client_ID", Client_ID);

            try
            {
                connection.Open();

                int row_affected = command.ExecuteNonQuery();

                if (row_affected > 0)
                {
                    isDeleted = true;
                }
                else
                {
                    isDeleted = false;
                }


            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                connection.Close();
            }

            return isDeleted;
        }

        static public bool Update_Client_By_ID
            (
                int Client_ID, int Person_ID, string AccountNumber, string FirstName, string LastName,
                string Country, string City, string Street,
                string Email, string PinCode,
                string Phone, double Balance
            )

        {

            bool result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE [Clients]" +
                " SET [Email] = @Email," +
                "[PinCode] = @PinCode," +
                "[AccountNumber] = @AccountNumber," +
                "[Phone] = @Phone," +
                "[Balance] = @Balance" +
                " WHERE [Client_ID] = @Client_ID;" +
                "" +
                "UPDATE Persons" +
                " SET [FirstName] = @FirstName," +
                "[LastName] = @LastName," +
                "[Country] = @Country," +
                "[City] = @City," +
                "[Street] = @Street " +
                " WHERE Person_ID = @Person_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Client_ID", Client_ID);
            command.Parameters.AddWithValue("@Person_ID", Person_ID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Street", Street);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                connection.Open();

                int row_affected = command.ExecuteNonQuery();

                if (row_affected > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                connection.Close();
            }

            return result;

        }

        static public bool Add_New_Client_By_ID
          (
              ref int Client_ID, ref int Person_ID,ref string AccountNumber, string FirstName, string LastName,
                string Country, string City, string Street,
                string Email, string PinCode,
                string Phone, double Balance
          )

        {
            bool result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "";

            if (Person_ID == -1)
            {
                query = " " +
                    "insert into Persons" +
                    " (FirstName,LastName,Country,City,Street) " +
                    "values " +
                    "(@FirstName,@LastName,@Country,@City,@Street);" +
                    " INSERT INTO Clients " +
                    "(Person_ID,AccountNumber,Email,[PinCode],Phone,Balance)" +
                    " VALUES ((select top 1 SCOPE_IDENTITY() from Persons),@AccountNumber,@Email,@PinCode,@Phone,@Balance) " +
                    "select top 1 SCOPE_IDENTITY() from Clients;";

            }



            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Street", Street);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Balance", Balance);


            try
            {
                connection.Open();

                object new_id = command.ExecuteScalar();

                if (new_id == null)
                {
                    result = false;
                }
                else
                {
                    Client_ID = Convert.ToInt32(new_id);
                    result = true;
                }

                // Getting Person_ID

                if (result == true)
                {
                    string query_to_get_person_id = "select Clients.Person_ID from Clients Where Client_ID = @Client_ID";

                    SqlCommand command_to_get_person_id = new SqlCommand(query_to_get_person_id, connection);
                    command_to_get_person_id.Parameters.AddWithValue("@Client_ID", Client_ID);

                    object person_id = command_to_get_person_id.ExecuteScalar();

                    if (person_id == null)
                    {
                        result = false;
                    }
                    else
                    {
                        Person_ID = Convert.ToInt32(person_id);
                    }

                    string queryToSetAccountNumber =
                        "UPDATE Clients " +
                        "SET AccountNumber = @AccountNumber " +
                        "WHERE Client_ID = @Client_ID;";

                    AccountNumber = (Client_ID + 1000).ToString() ;

                    SqlCommand commandToSetAccountNumber = new SqlCommand(queryToSetAccountNumber, connection);
                    commandToSetAccountNumber.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    commandToSetAccountNumber.Parameters.AddWithValue("@Client_ID", Client_ID);

                    commandToSetAccountNumber.ExecuteNonQuery();


                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                connection.Close();
            }

            return result;

        }


        static public DataTable Get_Clients_List()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Client_Person_List_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return table;
        }


    }
}
