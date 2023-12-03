using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write code that checks if the student's grade is above 50. If it is, print successful; if not, print unsuccessful

            int grade = 75;
            
            if(grade>50)
            {
                Console.WriteLine("Successful");
            }

        else
            {
                Console.WriteLine("Unsuccesful");
            }

            Console.ReadLine();

        }
    }
}
