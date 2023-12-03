using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseNotBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -Take input for 3 grades from the user.
            - Calculate the average of these grades.
            - If the average is between 80 and 100, print 'A+'.
            - If the average is between 60 and 80, print 'A'.
            - If the average is between 40 and 60, print 'B+'.
            - If the average is less than 40, print 'F'.
            */

            Console.Write("Please enter the first grade= ");

            int firstGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second grade= ");

            int secondGrade = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Please enter the third grade= ");

            int thirdGrade = Convert.ToInt32(Console.ReadLine());

            int result = (firstGrade + secondGrade + thirdGrade) / 3;

            if (result > 80 && result < 100)
            {
                Console.WriteLine("Value of your Grade : A+");

            }
            else if (result > 60 && result < 80)
            {
                Console.WriteLine("Value of your Grade : A");
            }
            else if (result > 40 && result < 60)
            {
                Console.WriteLine("Value of your Grade : B+");
            }
            else
            {
                Console.WriteLine("Value of your Grade : F");

            }
            Console.WriteLine("Your Average ="+result);
            Console.ReadLine();
        }
    }
}
