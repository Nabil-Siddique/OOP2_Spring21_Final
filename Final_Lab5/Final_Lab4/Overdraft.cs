using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
        class Overdraft : Account
        {
            public int limit { get; set; }

            public Overdraft() { }
            public Overdraft(string accName, string accNo, double balance, int limit) : base(accName, accNo, balance)
            {
                this.limit = limit;
            }

            public override void Withdraw(double amount)
            {
                if (amount <= Balance + limit)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Not sufficient fund.");
                }
            }
            public override void Transfer(Account acc, double amount)
            {
                if (amount <= Balance + limit)
                {
                    Balance -= amount;
                    acc.Balance += amount;
                }
                else
                {
                    Console.WriteLine("Not sufficient fund.");
                }
            }
        }
}
