using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            byte b = (byte)a;  // byte maxValue is 255 //There is a loss of byte value
            Console.WriteLine("int to byte=" + b.GetType());
            Console.WriteLine("Value of b=" + b);

            //Convert String to int

            string number1 = "1";
            string number2 = "2";
            Console.WriteLine("result of String Value=" + number1 + number2);

            int aa = int.Parse(number1);
            int bb = int.Parse(number2);
            int parseInt = aa + bb;
            Console.WriteLine("Value of intParse= "+ parseInt);

            // 2. Solution

            int d = Convert.ToInt32(number1);
            int e = Convert.ToInt32(number2);
            int convertToInt = d + e;
            Console.WriteLine("Value of ConvertToInt= " +convertToInt);

            // Convert Int to String

            int number3 = 9;

            int number4 = 7;

            string dd = number3.ToString();
            string ee = number4.ToString();

            Console.WriteLine("Value of String= " + dd + ee);

            //Convert Double to Inte

            double number5 = 5.22;

          
            int f = Convert.ToInt32(number5);
            Console.WriteLine("value of the ConvertMethod from double to int = " + f);
            Console.WriteLine(f.GetType());

            // enter two numbers and write a program that prints the sum of the two numbers on the screen
            Console.Write("Type the first number=");
            string number6 = Console.ReadLine();

            Console.Write("Type the second number=");
            string number7 = Console.ReadLine();

            int number6Int = int.Parse(number6);
            int number7Int = int.Parse(number7);

            Console.WriteLine("Sum of the number6 and number7= " +(number6Int+number7Int));









            Console.ReadLine();

        }
    }
}
