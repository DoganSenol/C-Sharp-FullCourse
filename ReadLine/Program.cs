using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadLine

            Console.WriteLine("Please type your firstName");

            string firstName = Console.ReadLine();

            Console.WriteLine("Please type your lastName");

            string lastName = Console.ReadLine();

            Console.WriteLine("UserFirstName:"+firstName);
            Console.WriteLine("UserLastName:"+lastName);

            Console.ReadLine();
        }
    }
}
