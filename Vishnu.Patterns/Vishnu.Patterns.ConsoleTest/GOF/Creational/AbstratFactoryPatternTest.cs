using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Creational.AbstractFactoryPattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class AbstratFactoryPatternTest
    {
        public static void Perform()
        {
            IPhoneFactory nokiaMobilePhone = new NokiaFactory();
            PhoneClient nokiaClient = new PhoneClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneDetails());

            IPhoneFactory samsungMobilePhone = new SamsungFactory();
            PhoneClient samsungClient = new PhoneClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneDetails());
        }
    }
}
