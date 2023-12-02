using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //equal operator : ==

            int number1 = 4;
            int number2 = 4;
            int number3 = 5;
            int number4 = 6;


            bool control1 = number1 == number2; //True
            bool control2 = number3 == number4; //False

            Console.WriteLine("Control1="+control1);
            Console.WriteLine("Control2="+ control2);
            Console.ReadLine();

        }
    }
}
