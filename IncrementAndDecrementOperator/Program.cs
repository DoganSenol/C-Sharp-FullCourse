using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementAndDecrementOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Increment Operator: ++
            //Decrement Operator: --

            int number = 20;
            number++;

            Console.WriteLine("IncrementedNumber="+number);
  

            number--;

            Console.WriteLine("DecrementedNumber="+number);
            Console.ReadLine();


        }
    }
}
