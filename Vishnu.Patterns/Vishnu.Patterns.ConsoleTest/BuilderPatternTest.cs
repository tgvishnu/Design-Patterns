using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Creational.BuilderPattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class BuilderPatternTest
    {
        public static void Perform()
        {
            Manufacturer manufacturer = new Manufacturer();
            IPhoneBuilder phoneBuilder = null;
            phoneBuilder = new AndriodPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("\n\nNew phone build : \n" + phoneBuilder.Phone.ToString());
            phoneBuilder = new WindowsPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("\n\nNew phone build : \n" + phoneBuilder.Phone.ToString());
            phoneBuilder = new SymbionPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("\n\nNew phone build : \n" + phoneBuilder.Phone.ToString());
        }
    }
}
