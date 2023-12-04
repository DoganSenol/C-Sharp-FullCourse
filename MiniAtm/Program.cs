using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             We will ask the user what operation they would like to perform
             Please select an operation:
             1-View Balance
             2-Withdraw Money
             3-Deposit Money
             Press q to exit
            */

            int balance = 1000;

            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Please select the operation you would like to perform");
            String choise = Console.ReadLine();

            if(choise == "1")
            {
                Console.WriteLine("Your current balance : " +balance);
                Console.ReadLine();
            }
            else if(choise == "2")
            {
                Console.WriteLine("Please enter the amount to be withdrawn");
                int amount_to_be_withdrawn = Convert.ToInt32(Console.ReadLine());
                
                if(amount_to_be_withdrawn<= balance)
                {
                    Console.WriteLine("Remaining balance :" + (balance - amount_to_be_withdrawn));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than your balance");
                    Console.ReadLine();

                }
               }
            else if (choise == "3")
            {
                Console.WriteLine("Please enter the amount you wish to deposit");
                int amount_to_be_deposited = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your current balance : " + (balance+amount_to_be_deposited));
                Console.ReadLine();

            }
            else if(choise == "q")
            {
                Console.WriteLine("Exiting from the ATM");
                Console.WriteLine("Exit completed. Have a nice day");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid value");
                Console.ReadLine();
            }


        }
    }
}
