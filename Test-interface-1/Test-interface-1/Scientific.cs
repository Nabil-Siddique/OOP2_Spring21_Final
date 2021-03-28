using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_interface_1.Interface;

namespace Test_interface_1
{
    class Scientific : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public Scientific() { }
        public Scientific(int firstNumber, int secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }
        public int division(int x, int y)
        {
            return x / y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }

        public int XtoY(int x, int y)
        {
            return (int)Math.Pow(x, y);
        }
    }
}
