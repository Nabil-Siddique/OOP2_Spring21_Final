using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_interface_1.Interface;

namespace Test_interface_1
{
    class Calculator : BasicCalculatorInterface
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public Calculator() { }

        public Calculator(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public int division(int x, int y)
        {
            return x / y;
        }
    }
}
