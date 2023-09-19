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

        public DataTable List()
        {

        }

        public int Transaction_ID { get; private set; }
        public clsClient Sender { get; set; }
        public clsClient Receiver { get; set; }
        public clsUser User { get; set; }
        public int TransactionType_ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDateTime { get; set; }

        private clsTransaction(int transactionID, clsClient sender, clsClient receiver, clsUser user, int transactionTypeID, decimal amount, DateTime transactionDateTime)
        {
            Transaction_ID = transactionID;
            Sender = sender;
            Receiver = receiver;
            User = user;
            TransactionType_ID = transactionTypeID;
            Amount = amount;
            TransactionDateTime = transactionDateTime;
        }
    }


}
