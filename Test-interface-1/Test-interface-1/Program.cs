using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int sum = cal.sum(100, 200);
            Console.WriteLine(sum);

            Scientific sc = new Scientific();
            int res = sc.XtoY(4, 2);
            Console.WriteLine(res);

        }
    }
}
