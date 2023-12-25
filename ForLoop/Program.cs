using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 den 10 a kadar olan sayilari alt alta ekrana yazdiran programi kodlayiniz
            // 1 den 10 a kadar olan sayilardan cift olanlarini ekrana yazdiriniz

            /*
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            for(int a =0; a<=10; a=a+2)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
