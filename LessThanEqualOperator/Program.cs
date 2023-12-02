using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessThanEqualOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //less than operator : <
            //less than and equal operator : <=

            int age = 18;

            bool control1 = age < 19; //true
            bool control2 = age <= 18; //true

            //negative test

            bool control3 = age < 18; //false

            Console.WriteLine("Control1="+control1);
            Console.WriteLine("Control2=" + control2);
            Console.WriteLine("Control3=" + control3);
            Console.ReadLine();
        }
    }
}
