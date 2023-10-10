using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;

namespace Bank_Business_Layer
{

    using System;

    public class clsTransaction
    {

        static public DataTable Table()
        {
            return clsDataAccessLayer.Get_Transaction_List();
        }

        static public List<clsTransaction> List()
        {
            DataTable table = clsTransaction.Table();
            List < clsTransaction > list = new List < clsTransaction >();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new clsTransaction(row));
            }

            return list;
        }

        static public List<clsTransaction> From_Table_To_List(DataTable table)
        {

            List<clsTransaction> list = new List<clsTransaction>();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new clsTransaction(row));
            }

            return list;
        }



        public int Transaction_ID { get; private set; }
        public clsClient Sender { get; set; }

        private int Sender_ID;
        public clsClient Receiver { get; set; }

        private int Receiver_ID;
        public clsUser User { get; set; }

        private int User_ID;

        public int TransactionType_ID { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDateTime { get; set; }

        public double SenderBalanceBefore { get; set; }
        public double SenderBalanceAfter { get; set; }

        public double ReceiverBalanceBefore { get; set; }
        public double ReceiverBalanceAfter { get; set; }


      
        public enTransaction TransactionType { get; private set ; }
        public enum enTransaction { eDeposit = 1, eWithdraw, eTransfer };

        static public string[] TransactionTypes = { "Undefined","Deposit","Withdraw","Transfer" };
        
        static public clsTransaction Find(int Transaction_ID)
        {
            DataRow dataRow = clsTransaction.Table().Select($"Transaction_ID = {Transaction_ID}")[0];
            return new clsTransaction(dataRow) ;
        }
        private clsTransaction(DataRow row)
        {
            Transaction_ID = Convert.ToInt32( row["Transaction_ID"]);
            TransactionType_ID = Convert.ToInt32(row["TransactionType_ID"]);
            Amount = Convert.ToDouble(row["Amount"]);
            TransactionDateTime = Convert.ToDateTime(row["TransactionDateTime"]); ;

            if (row["Sender_ID"] == DBNull.Value)
            {
                Sender = null;
            }
            else
            {
                Sender = clsClient.Find(Convert.ToInt32(row["Sender_ID"]));
            }

            if (row["Receiver_ID"] == DBNull.Value)
            {
                Receiver = null;
            }
            else
            {
                Receiver = clsClient.Find(Convert.ToInt32(row["Receiver_ID"]));
            }

            if (row["User_ID"] == DBNull.Value)
            {
                User = null;
            }
            else
            {
                User = clsUser.Find(Convert.ToInt32(row["User_ID"]));
            }
        }
        private clsTransaction(int transactionID,int sender_id, int receiver_id, int user_id, int transactionTypeID, double amount, DateTime transactionDateTime)
        {
            Transaction_ID = transactionID;
            TransactionType_ID = transactionTypeID;
            Amount = amount;
            TransactionDateTime = transactionDateTime;

            if (sender_id == -1)
            {
                Sender = null;
            }
            else
            {
                Sender = clsClient.Find(sender_id);
            }

            if (receiver_id == -1)
            {
                Receiver = null;
            }
            else
            {
                Receiver = clsClient.Find(receiver_id);
            }

            if(user_id == -1)
            {
                User = null;
            }
            else
            {
                User = clsUser.Find(user_id);
            }

        }
        public clsTransaction(enTransaction trans_type,int sender_id, int receiver_id, int user_id, int transactionTypeID, double amount, DateTime transactionDateTime)
        {
            TransactionType_ID = transactionTypeID;
            Amount = amount;
            TransactionDateTime = transactionDateTime;
            Sender_ID = sender_id;
            Receiver_ID = receiver_id;
            User_ID = user_id;

            if (sender_id == -1)
            {
                Sender = null;
            }
            else
            {
                Sender = clsClient.Find(sender_id);
                SenderBalanceAfter = Sender.Balance - amount;
                SenderBalanceBefore = Sender.Balance;
            }

            if (receiver_id == -1)
            {
                Receiver = null;
            }
            else
            {
                Receiver = clsClient.Find(receiver_id);
                ReceiverBalanceBefore = Receiver.Balance;
                ReceiverBalanceAfter = Receiver.Balance + amount;
            }

            if (user_id == -1)
            {
                User = null;
            }
            else
            {
                User = clsUser.Find(user_id);
            }

        }


        public clsTransaction(enTransaction trans_type, int sender_id, int receiver_id, int user_id, int transactionTypeID, double amount, DateTime transactionDateTime,double SenderBalanceBefor,double ReceiverBalanceBefor)
        {
            TransactionType_ID = transactionTypeID;
            Amount = amount;
            TransactionDateTime = transactionDateTime;

            Sender_ID = sender_id;
            Receiver_ID = receiver_id;
            User_ID = user_id;

            this.SenderBalanceBefore = SenderBalanceBefor;
            this.ReceiverBalanceBefore = ReceiverBalanceBefor;

            this.SenderBalanceAfter = this.SenderBalanceBefore - amount;
            this.ReceiverBalanceAfter = this.ReceiverBalanceBefore + amount;
        }

        public bool Save()
        {
            return clsDataAccessLayer.Add_New_Transaction
                (
                    Sender_ID,
                    Receiver_ID,
                    User_ID,
                    TransactionType_ID,
                    Amount,
                    TransactionDateTime,
                    SenderBalanceBefore,
                    SenderBalanceAfter,
                    ReceiverBalanceBefore,
                    ReceiverBalanceAfter
                );


        }
    }


}
