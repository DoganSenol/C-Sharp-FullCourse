using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // break anahtar kelimesi
            // continue anahtar kelimesi

            /*
            for (int a = 1; a <= 10; a++)
            {
                if(a==7)
                    {
                    break;

                }
                Console.WriteLine("a ' nin degeri :"+a);
            }
            Console.ReadLine();
            */

            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue;

                }
                Console.WriteLine("a ' nin degeri :" + a);
            }
            Console.ReadLine();
        }
    }
    }

