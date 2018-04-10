using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter you choice");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "2":
                        AbstratFactoryPatternTest.Perform();
                        break;
                        
                }
            } while (choice != "0");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("2. AbstractFactoryPattern");
            Console.WriteLine("");
        }
    }
}
