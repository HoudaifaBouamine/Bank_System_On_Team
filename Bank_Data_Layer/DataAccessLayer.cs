﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Layer
{
    public class clsDataAccessLayer
    {

        static public void testing ()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "select Permission from users where User_ID=1;";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                Console.WriteLine("Connected successfuly\n\n");

                object test = cmd.ExecuteScalar();
                if(test != null)
                {
                    Console.WriteLine("\n\nPerson 1 permisstion : " + Convert.ToInt32(test));
                }
                else
                {
                    Console.WriteLine("Failed to execute commadn");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Conncetion Failed : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }



        }

        /// <summary>
        /// Search on the Database for client by <c>Client_ID</c> and return the client info as variables using <c>ref</c> key word
        /// </summary>
        /// <param name="Client_ID"></param>
        /// <returns>return <c>true</c> if the Client found succssufuly, otherwise return <c>flase</c></returns>
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

        /// <summary>
        /// Search on the Database for user by <c>User_ID</c> and return the user info as variables using <c>ref</c> key word
        /// </summary>
        /// <param name="User_ID"></param>
        /// <returns>return <c>true</c> if the User found succssufuly, otherwise return <c>flase</c></returns>
        static public bool Find_User_By_ID
            (
                int User_ID, ref int Person_ID,ref string UserName, ref string FirstName, ref string LastName,
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
                    UserName = (string)reader["UserName"];

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

        /// <summary>
        /// Create new User on the Database ,
        /// if user created successfuly return by <c>ref</c>
        /// the <c>User_ID</c> and <c>Person_ID</c><br></br>
        /// </summary>
        /// <param name="User_ID">must have reference to store the <c>User_ID</c> on it</param>
        /// <param name="Person_ID">must have reference to store the <c>Person_ID</c> on it</param>
        /// <returns>return <c>true</c> if the User added succssufuly, otherwise return <c>flase</c></returns>
        static public bool Add_New_User_By_User_ID
            (
                ref int User_ID,ref int Person_ID,string UserName, string FirstName, string LastName,
                string Country, string City, string Street,
                string Email, string Password,
                string Phone, int Permission
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
                    " INSERT INTO Users " +
                    "(Person_ID,UserName,Email,[Password],Phone,Permission)" +
                    " VALUES ((select top 1 SCOPE_IDENTITY() from Persons),@UserName,@Email,@Password,@Phone,@Permission) " +
                    "select top 1 SCOPE_IDENTITY() from Users;";

            }
            
            

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Street", Street);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Permission", Permission);


            try
            {
                connection.Open();

                object new_id = command.ExecuteScalar();

                if(new_id == null)
                {
                    result = false;
                }
                else
                {
                    User_ID = Convert.ToInt32(new_id);
                    result = true;
                }

                // Getting Person_ID

                if(result == true)
                {
                    string query_to_get_person_id = "select Users.Person_ID from Users Where User_ID = @User_ID";

                    SqlCommand command_to_get_person_id = new SqlCommand(query_to_get_person_id, connection);
                    command_to_get_person_id.Parameters.AddWithValue("@User_ID", User_ID);

                    object person_id = command_to_get_person_id.ExecuteScalar();

                    if (person_id == null)
                    {
                        result = false;
                    }
                    else
                    {
                        Person_ID = Convert.ToInt32(person_id);
                    }
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

        /// <summary>
        /// Update the user by <c>User_ID</c><br></br>
        /// <c>Person_ID</c> is required to find the Person row on the database and update it
        /// </summary>
        /// <returns>return <c>true</c> if the User updated succssufuly, otherwise return <c>flase</c></returns>
        static public bool Update_User_By_ID
            (
                int User_ID,int Person_ID,string UserName, string FirstName, string LastName,
                string Country, string City, string Street,
                string Email, string Password,
                string Phone, int Permission
            )

        {

            bool result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE [Users]" +
                " SET [Email] = @Email," +
                "[Password] = @Password," +
                "[UserName] = @UserName," +
                "[Phone] = @Phone," +
                "[Permission] = @Permission" +
                " WHERE [User_ID] = @User_ID;" +
                "" +
                "UPDATE Persons" +
                " SET [FirstName] = @FirstName," +
                "[LastName] = @LastName," +
                "[Country] = @Country," +
                "[City] = @City," +
                "[Street] = @Street " +
                " WHERE Person_ID = @Person_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_ID", User_ID);
            command.Parameters.AddWithValue("@Person_ID", Person_ID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Street", Street);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();

                int row_affected = command.ExecuteNonQuery();

                if(row_affected > 0)
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

        /// <summary>
        /// return lists of all users info
        /// </summary>
        /// <returns>return <c>true</c> if the it get the list successfuly, otherwise return false</returns>
        static public bool Get_Users_List
            (
                ref List<int> User_ID, ref List<int> Person_ID,ref List<string> UserName, ref List<string> FirstName, ref List<string> LastName,
                ref List<string> Country, ref List<string> City, ref List<string> Street,
                ref List<string> Email, ref List<string> Password,
                ref List<string> Phone, ref List<int> Permission
            )
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Persons.FirstName,Persons.LastName,Persons.Country,Persons.City,Persons.Street ,Users.* from Users Inner join Persons on Persons.Person_ID = Users.Person_ID";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {

                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User_ID.Add(Convert.ToInt32(reader["User_ID"]));
                    Person_ID.Add(Convert.ToInt32(reader["Person_ID"]));
                    UserName.Add((string)reader["UserName"]);
                    FirstName.Add((string)reader["FirstName"]);
                    LastName.Add((string)reader["LastName"]);
                    Country.Add((string)reader["Country"]);
                    City.Add((string)reader["City"]);
                    Street.Add((string)reader["Street"]);
                    Email.Add((string)reader["Email"]);
                    Password.Add((string)reader["Password"]);
                    Phone.Add((string)reader["Phone"]);
                    Permission.Add(Convert.ToInt32(reader["Permission"]));

                }

                reader.Close();
                result = true;

            }
            catch ( Exception ex )
            {
                result = false;
            }
            finally 
            {
                connection.Close(); 
            }

            return result;
        }

        /// <summary>
        /// Get <c>User_ID</c> and delete the user 
        /// </summary>
        /// <param name="User_ID"></param>
        /// <returns>return <c>true</c> if the user deleted successfuly, otherwise return false</returns>
        static public bool Delete_User_By_ID(int User_ID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Persons WHERE Persons.Person_ID = (select Users.Person_ID from Users WHERE Users.User_ID = @User_ID); DELETE FROM Users WHERE User_ID = @User_ID; ";

            // NOTE (HOUDAIFA) : You have to modify this query to check if the Person is related to a client (because a person may be a client and a user at the same time)

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_ID", User_ID);

            try
            {
                connection.Open();

                int row_affected = command.ExecuteNonQuery();

                if(row_affected > 0)
                {
                    isDeleted = true;
                }
                else
                {
                    isDeleted = false;
                }


            }
            catch ( Exception ex )
            {
                isDeleted = false;
            }
            finally
            { 
                connection.Close();
            }

            return isDeleted;
        }
    }
}
