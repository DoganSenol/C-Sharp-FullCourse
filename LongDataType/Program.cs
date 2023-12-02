using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // long data type stores values between -9223372036854775808 to 9223372036854775807.
            // Takes up 8 bytes in RAM memory

            long firstValue = 575000;

            long secondValue = -500;

            long maxValue = long.MaxValue;

            long minValue = long.MinValue;

            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.ReadLine();
        }
    }
}
