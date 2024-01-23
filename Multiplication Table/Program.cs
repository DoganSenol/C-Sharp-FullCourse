using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication Table with for Loop

            for (int i = 1; i <= 10; i++) //100
            {
                for(int j=1; j<=10; j++) //1000
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }
            }
            Console.ReadLine();
        }
    }
}
