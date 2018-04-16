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
                    case "1":
                        ProcessCreationalPattern();
                        break;
                    case "2":
                        ProcessStructuralPattern();
                        break;
                    case "3":
                        ProcessBehaviouralPatten();
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
            Console.WriteLine("1.  Creational Patterns");
            Console.WriteLine("2.  Structural Patterns");
            Console.WriteLine("3.  Behavioral Patterns");
            Console.WriteLine("***************************************");
        }

        private static void PrintCreationalPatternMenu()
        {
            Console.WriteLine("********** Creational Patterns **********");
            Console.WriteLine("0.  Back to Main menu");
            Console.WriteLine("1.  Abstract Factory Pattern");
            Console.WriteLine("2a. Factory Method Pattern with DI");
            Console.WriteLine("2b. Factory Mehtod Pattern without DI");
            Console.WriteLine("3.  Builder Pattern");
            Console.WriteLine("4.  Prototype Pattern");
            Console.WriteLine("***************************************");
        }

        private static void ProcessCreationalPattern()
        {
            string choice = string.Empty;
            do
            {
                PrintCreationalPatternMenu();
                Console.WriteLine("Select any choice ");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Abstract Factory Pattern.....");
                        AbstratFactoryPatternTest.Perform();
                        break;
                    case "2a":
                        Console.WriteLine("Factory Method Pattern with DI...");
                        FactoryPatternWithDITest.Perform();
                        break;
                    case "2b":
                        Console.WriteLine("Factory Method Pattern without DI...");
                        FactoryPatternWithoutDITest.Perform();
                        break;
                    case "3":
                        Console.WriteLine("Builder pattern...");
                        BuilderPatternTest.Perform();
                        break;
                    case "4":
                        Console.WriteLine("Prototype pattern...");
                        PrototypePatternTest.Perform();
                        break;
                }
            } while (choice != "0");
        }

        private static void PrintBehavioralPatternMenu()
        {
            Console.WriteLine("**********  Behavioural Pattern **********");
            Console.WriteLine("0.  Back to Main menu");
            Console.WriteLine("***************************************");
        }

        private static void ProcessBehaviouralPatten()
        {
            string choice = string.Empty;
            do
            {
                PrintBehavioralPatternMenu();
                Console.WriteLine("Select any choice ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    default:
                        break;
                }
            } while (choice != "0");
        }

        private static void PrintStructuralPatternMenu()
        {
            Console.WriteLine("**********  Structural Pattern **********");
            Console.WriteLine("0.  Back to Main menu");
            Console.WriteLine("1.  Adapter Pattern");
            Console.WriteLine("***************************************");
        }

        private static void ProcessStructuralPattern()
        {
            string choice = string.Empty;
            do
            {
                PrintStructuralPatternMenu();
                Console.WriteLine("Select any choice ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Adapter Pattern.....");
                        AdapterPatternTest.Perform();
                        break;
                }
            } while (choice != "0");
        }
    }
}
