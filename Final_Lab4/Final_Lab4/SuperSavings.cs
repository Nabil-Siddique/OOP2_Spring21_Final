using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
    class SuperSavings : Account
    {
        public double openingAmount { get; set; }
        public SuperSavings(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {
            this.openingAmount = balance;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance - (openingAmount * 20 / 100))
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Not sufficient fund. Min amount " + openingAmount * 20 / 100);
            }
        }

        public override void Transfer(Account acc, double amount)
        {
            if (amount <= Balance - (openingAmount * 20 / 100))
            {
                Balance -= amount;
                acc.Balance += amount;
            }
            else
            {
                Console.WriteLine("Not sufficient fund. Min amount " + openingAmount * 20 / 100);
            }
        }
    }
}
