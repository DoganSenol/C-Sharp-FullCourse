using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //The short variable can have values between -32768 and 32767.

            short firstValue = -50;

            short secondValue = 25550;

            short thirdValue = 32000;

            short maxValue = short.MaxValue;

            short minValue = short.MinValue;

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);

            Console.ReadLine();

        }
    }
}
