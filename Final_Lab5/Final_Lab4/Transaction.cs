using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
    class Transaction
    {
        private Account sender;
        private Account receiver;
        public double Amount { get; set; }
        public string AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            AdditionalInfo = additionalInfo;
            Amount = amount;
        }

        public void showTransactions()
        {
            Console.WriteLine("Transaction type: " + AdditionalInfo);
            if (AdditionalInfo.ToLower().Equals("transfer"))
            {
                Console.WriteLine("Sender: " + sender);
                Console.WriteLine("Receiver: " + receiver);
            }
            Console.Write("Amount: " + Amount);
        }
    }
}
