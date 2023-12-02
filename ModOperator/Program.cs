using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // mod Operator : %

            int number1 = 10;
            int number2 = 3;
            int mod = number1 % number2;

            Console.WriteLine("mod="+mod);
            //Console.WriteLine("Mod="+number1%number2);
            Console.ReadLine();
        }
    }
}
