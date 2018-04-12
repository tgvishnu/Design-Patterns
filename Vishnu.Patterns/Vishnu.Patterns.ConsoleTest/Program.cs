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
                Console.WriteLine("\n");
                PrintMenu();
                Console.WriteLine("Enter you choice");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "-1":
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("Abstract Factory Pattern.....");
                        AbstratFactoryPatternTest.Perform();
                        break;
                    case "3a":
                        Console.WriteLine("Factory Method Pattern with DI...");
                        FactoryPatternWithDITest.Perform();
                        break;
                    case "3b":
                        Console.WriteLine("Factory Method Pattern without DI...");
                        FactoryPatternWithoutDITest.Perform();
                        break;
                    case "4":
                        Console.WriteLine("Builder pattern...");
                        BuilderPatternTest.Perform();
                        break;
                    case "5":
                        Console.WriteLine("Prototype pattern...");
                        PrototypePatternTest.Perform();
                        break;

                }
            } while (choice != "0");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("********** Menu  **********************");
            Console.WriteLine("-1. Clear Screen");
            Console.WriteLine("0.  Exit");
            Console.WriteLine("2.  Abstract Factory Pattern");
            Console.WriteLine("3a. Factory Method Pattern with DI");
            Console.WriteLine("3b. Factory Mehtod Pattern without DI");
            Console.WriteLine("4.  Builder Pattern");
            Console.WriteLine("5.  Prototype Pattern");
            Console.WriteLine("***************************************");
        }
    }
}
