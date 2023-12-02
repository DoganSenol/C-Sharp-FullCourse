using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //float take 4 byte ram

            float firstValue = 35.56f;

            float secondValue = 12.5f;

            float maxValue = float.MaxValue;

            float minValue = float.MinValue;

            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.ReadLine();
        }
    }
}
