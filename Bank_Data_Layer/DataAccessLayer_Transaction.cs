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

        static public DataTable Get_Transaction_List()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Transaction_Details_View;";

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

        static public DataTable Get_Transaction_List_Client_ID(int Client_ID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Transactions Where Sender_ID = @Client_ID or Receiver_ID = @Client_ID ORDER BY TransactionDateTime DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Client_ID", Client_ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        static public bool Add_New_Transaction(
        int senderID,
        int receiverID,
        int userID,
        int transactionTypeID,
        double amount,
        DateTime transactionDateTime,
        double senderBalanceBefore,
        double senderBalanceAfter,
        double receiverBalanceBefore,
        double receiverBalanceAfter)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Transactions (Sender_ID, Receiver_ID, User_ID, TransactionType_ID, Amount, TransactionDateTime, Sender_Balance_Befor, Sender_Balance_After, Receiver_Balance_Befor, Receiver_Balance_After) VALUES (@Sender_ID, @Receiver_ID, @User_ID, @TransactionType_ID, @Amount, @TransactionDateTime, @Sender_Balance_Befor, @Sender_Balance_After, @Receiver_Balance_Befor, @Receiver_Balance_After)", connection))
                    {
                        if (senderID == -1)
                        {
                            cmd.Parameters.AddWithValue("@Sender_ID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Sender_ID", senderID);
                        }

                        if (receiverID == -1)
                        {
                            cmd.Parameters.AddWithValue("@Receiver_ID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Receiver_ID", receiverID);
                        }

                        if (userID == -1)
                        {
                            cmd.Parameters.AddWithValue("@User_ID", DBNull.Value);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@User_ID", userID);
                        }

                        cmd.Parameters.AddWithValue("@TransactionType_ID", transactionTypeID);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@TransactionDateTime", transactionDateTime);
                        cmd.Parameters.AddWithValue("@Sender_Balance_Befor", senderBalanceBefore);
                        cmd.Parameters.AddWithValue("@Sender_Balance_After", senderBalanceAfter);
                        cmd.Parameters.AddWithValue("@Receiver_Balance_Befor", receiverBalanceBefore);
                        cmd.Parameters.AddWithValue("@Receiver_Balance_After", receiverBalanceAfter);

                        cmd.ExecuteNonQuery();
                    }
                }
            } catch(Exception ex) 
            {
                return false;
            }

            return true;

        }

    }
}
