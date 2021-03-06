﻿using System;
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
                PrintPatternsMenu();
                Console.WriteLine("Enter you choice");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "-1":
                        Console.Clear();
                        break;
                    case "1":
                        ProcessGOFPatterns();
                        break;
                }
            } while (choice != "0");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static void PrintPatternsMenu()
        {
            Console.WriteLine("********** Menu  **********************");
            Console.WriteLine("-1. Clear Screen");
            Console.WriteLine("0.  Exit");
            Console.WriteLine("1.  GOF Patterns");
            Console.WriteLine("***************************************");
        }


        private static void PrintGOFMenu()
        {
            Console.WriteLine("********** Menu  **********************");
            Console.WriteLine("\t-1. Clear Screen");
            Console.WriteLine("\t0.  Exit");
            Console.WriteLine("\t1.  Creational Patterns");
            Console.WriteLine("\t2.  Structural Patterns");
            Console.WriteLine("\t3.  Behavioral Patterns");
            Console.WriteLine("***************************************");
        }

        private static void ProcessGOFPatterns()
        {
            string choice = string.Empty;
            do
            {
                PrintGOFMenu();
                Console.WriteLine("Select any choice ");
                choice = Console.ReadLine();
                switch (choice)
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
        }

        private static void PrintCreationalPatternMenu()
        {
            Console.WriteLine("\t********** Creational Patterns **********");
            Console.WriteLine("\t-1. Clear Screen");
            Console.WriteLine("\t0.  Back to Main menu");
            Console.WriteLine("\t1.  Abstract Factory Pattern");
            Console.WriteLine("\t2a. Factory Method Pattern with DI");
            Console.WriteLine("\t2b. Factory Mehtod Pattern without DI");
            Console.WriteLine("\t3.  Builder Pattern");
            Console.WriteLine("\t4.  Prototype Pattern");
            Console.WriteLine("\t***************************************");
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
                    case "-1":
                        Console.Clear();
                        break;
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
            Console.WriteLine("\t**********  Behavioural Pattern **********");
            Console.WriteLine("\t-1. Clear Screen");
            Console.WriteLine("\t0.  Back to Main menu");
            Console.WriteLine("\t1.  Chain of Responsibilit");
            Console.WriteLine("\t***************************************");
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
                    case "-1":
                        Console.Clear();
                        break;
                    case "1":
                        Console.WriteLine("Chain of responsibility pattern...");
                        ChainOfResponsibilityPatternTest.Perform();
                        break;
                    default:
                        break;
                }
            } while (choice != "0");
        }

        private static void PrintStructuralPatternMenu()
        {
            Console.WriteLine("\t**********  Structural Pattern **********");
            Console.WriteLine("\t-1. Clear Screen");
            Console.WriteLine("\t0.  Back to Main menu");
            Console.WriteLine("\t1.  Adapter Pattern");
            Console.WriteLine("\t2.  Bridge Pattern");
            Console.WriteLine("\t3.  Composite Pattern");
            Console.WriteLine("\t4.  Decorator Pattern");
            Console.WriteLine("\t5.  Facade Pattern");
            Console.WriteLine("\t6.  Proxy Pattern");
            Console.WriteLine("\t***************************************");
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
                    case "-1":
                        Console.Clear();
                        break;
                    case "1":
                        Console.Write("Adapter Pattern.....");
                        AdapterPatternTest.Perform();
                        break;
                    case "2":
                        Console.WriteLine("Bridge Pattern...");
                        BridgePatternTest.Perform();
                        break;
                    case "3":
                        Console.WriteLine("Composite Pattern...");
                        CompositePatternTest.Perform();
                        break;
                    case "4":
                        Console.WriteLine("Decorator Pattern...");
                        DecoratorPatternTest.Perform();
                        break;
                    case "5":
                        Console.WriteLine("Facade Pattern....");
                        FacadePatternTest.Perform();
                        break;
                    case "6":
                        Console.WriteLine("Proxy Pattern...");
                        ProxyPatternTest.Perform();
                        break;
                }
            } while (choice != "0");
        }
    }
}
