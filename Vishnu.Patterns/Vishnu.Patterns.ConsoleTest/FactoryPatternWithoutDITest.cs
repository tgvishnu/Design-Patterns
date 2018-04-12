using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Creational.FactoryPattern.WithoutDI;

namespace Vishnu.Patterns.ConsoleTest
{
    public class FactoryPatternWithoutDITest
    {
        public static void Perform()
        {
            var factory = new DefaultPaymentGatewayFactory();
            IPaymentGateWay gateway = factory.Create(Gateways.Swift);
            gateway.Invoke();
            gateway = factory.Create(Gateways.WellsFargo);
            gateway.Invoke();
            gateway = factory.Create(Gateways.ProtocolBase);
            gateway.Invoke();
            Console.WriteLine("");
        }
    }
}
