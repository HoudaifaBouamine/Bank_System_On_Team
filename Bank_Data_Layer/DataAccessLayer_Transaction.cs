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

    }
}
