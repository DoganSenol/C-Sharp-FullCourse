using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Body Mass Index = Weight / height*height
            // If the Body Mass Index is equal to or less than 18, it is considered UNDERWEIGHT.
            // If it is between 18 and 25, it is considered NORMAL.
            // If it is greater than 25, it is considered OBESE.

            Console.Write("Please Enter your weight= ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter your height= ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            if (bmi < 18)
            {
                Console.WriteLine("UNDERWEIGHT...");
                Console.ReadLine();
            }
            else if(bmi>18 && bmi<25)
            {
                Console.WriteLine("NORMAL...");
                Console.ReadLine();
            }
            else if(bmi> 25)
            {
                Console.WriteLine("OBESE...");
                Console.ReadLine();
            }
        }
    }
}
