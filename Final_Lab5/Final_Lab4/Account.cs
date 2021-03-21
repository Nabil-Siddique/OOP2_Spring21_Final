using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }
        Transaction[] transactions;
        public int transactionCount { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            transactions = new Transaction[20];
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("your account credited by {0}. Current balance: {1}", amount, Balance);
            transactions[transactionCount++] = new Transaction(this, this, amount, "Deposit");
        }

        public void addTransaction(Account sender, Account receiver, double amount)
        {
            foreach (Transaction transaction in transactions)
            {
                this.transactions[transactionCount++] = transaction;
            }
        }

        public void showAllTransaction()
        {
            Console.WriteLine("Transaction history ");

            for (int i = 0; i < transactionCount; i++)
            {
                transactions[i].showTransactions();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("\tAccount Name: " + AccName);
            Console.WriteLine("\tAccount Number: " + AccNo);
            Console.WriteLine("\tCurrent Balance: " + Balance);
            Console.WriteLine();
        }

        public abstract void Withdraw(double amount);
        public abstract void Transfer(Account acc, double amount);
    }
}
