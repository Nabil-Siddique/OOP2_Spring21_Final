using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
    class Savings : Account
    {

        public Savings(string AccName, string AccNo, double balance) : base(AccName, AccNo, balance) { }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance - 500)
            {
                Balance -= amount;
                Console.WriteLine("Your account debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance, min balance 500");
            }

        }

        public override void Transfer(Account acc, double amount)
        {
            if (amount <= Balance - 500)
            {
                Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("your account transfer by {0} to the account {1}({2})", amount, acc.AccName, acc.AccNo);
            }
            else
            {
                Console.WriteLine("Insufficient balance, min balance 500");
            }
        }
    }
}
