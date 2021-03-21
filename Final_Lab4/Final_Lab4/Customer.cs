using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
    class Customer
    {
        public string Name { get; set; }
        Account[] accounts;
        public int AccCount;
        public Customer(string name)
        {
            Name = name;
            accounts = new Account[10];
        }

        public void AddAccount(params Account[] accounts)
        {
            foreach (Account acc in accounts)
            {
                this.accounts[AccCount++] = acc;
            }
        }

        public void AccDetails()
        {
            Console.WriteLine("Customer name: " + Name);

            for (int i = 0; i < AccCount; i++)
            {
                accounts[i].ShowInfo();
            }
        }

        public Account findAccount(string accNo)
        {
            Account acc = null;
            for (int i = 0; i < AccCount; i++)
            {
                if (accNo.Equals(accounts[i].AccNo))
                {
                    acc = accounts[i];
                    break;
                }
            }
            return acc;
        }
    }
}
