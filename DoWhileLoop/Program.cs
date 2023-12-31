using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayilari ekrana yazdiriniz (do while)

            // 1 den 100 e kadar olan  sayilarin toplamini ekrana yazdiriniz (do while)

            /* int a = 1;

             do
             {
                 Console.WriteLine(a);
                 a++;

             } while (a <= 10);

             Console.ReadLine();
         } */

            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;

            } while (a <= 100);

            Console.WriteLine("1 den 100 e kadar olan sayilarin Toplami :" + toplam);

            Console.ReadLine();

        }
    }
}
