using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            byte first = 5;

            byte second = 25;

            byte third = 255; //0-255

            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.ReadLine();
        }
    }
}
