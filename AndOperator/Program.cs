using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // && and Operator

            int number1 = 5;

            int number2 = 5;

            int number3 = 10;

            bool control = number1 == number2 && number1 < number3; // True

            Console.WriteLine("Control="+ control);
            Console.ReadLine();

        }
    }
}
