using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Or Operator : ||

            int number1 = 3;

            int number2 = 3;

            int number3 = 6;

            bool control = number1 == number2 || number3 > number1 && number3 > number2;

            Console.WriteLine("Control="+control);
            Console.ReadLine();


        }
    }
}
