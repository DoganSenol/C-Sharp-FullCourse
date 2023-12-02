using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDataType
{
    class Program
    {
        static void Main(string[] args)
        {

            // Takes up 8 bytes of RAM
            // Can hold 15 digit decimal numbers

            double firstValue = 350.7;

            double secondValue = -250.6;

            double maxValue = double.MaxValue;

            double minValue = double.MinValue;




            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.ReadLine();


        }
    }
}
