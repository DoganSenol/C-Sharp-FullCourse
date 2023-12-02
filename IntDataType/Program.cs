using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // int data type stores values between -2.147.483.648 and 2.147.483.647.
            // Takes up 4 byes in RAM memory

            //8 bit     = 1     byte
            //1024 byte = 1 KB  (kilobyte)
            //1024 KB   = 1 MB  (megabyte)
            //1024 MB   = 1 GB  (gigabyte)
            //1024 GB   = 1 TB  (terabyte)
            //1024 TB   = 1 PB  (petabyte)

            int firstDataType = 150000;

            int secondDataType = -500000;

            int maxValue = int.MaxValue;

            int minValue = int.MinValue;


            Console.WriteLine(firstDataType);
            Console.WriteLine(secondDataType);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.ReadLine();


        }
    }
}
