using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEqualOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not Equal Operator : !=

            int number1 = 3;
            int number2 = 4;

            int number3 = 5;
            int number4 = 5;

            bool result1 = number1 != number2;  //true
            bool result2 = number3 != number4; //false

            Console.WriteLine("Result1="+result1);
            Console.WriteLine("Result2=" + result2);
            Console.ReadLine();
        }
    }
}
