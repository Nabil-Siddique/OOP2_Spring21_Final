using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Interface_2.Interface;

namespace Test_Interface_2
{
    abstract class Account : BasicBankingInterface
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public int balance { get; set; }

        public Account(string accName, string accNo, int balance)
        {
            this.AccName = accName;
            this.AccNo = accNo;
            this.balance = balance;
        }

        public void showInfo()
        {
            Console.WriteLine("Account name: " + AccName);
            Console.WriteLine("Account no: " + AccNo);
            Console.WriteLine("Balance: " + balance);
        }

        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);
    }
}
