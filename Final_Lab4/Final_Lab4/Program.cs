using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ali = new Savings("Ali", "001", 5000.0f);
            Account antoraj = new Current("Antoraj", "002", 2000f);
            Account sakib = new Fixed("Sakib", "003", 1000f, 2015, 10);

            Account ss = new SuperSavings("Arif", "004", 100f);
            ss.Withdraw(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Arifur", "005", 1000f, 5000);
            overdraft.Transfer(ss, 5000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Ali Antoraj");

        }
    }
}
