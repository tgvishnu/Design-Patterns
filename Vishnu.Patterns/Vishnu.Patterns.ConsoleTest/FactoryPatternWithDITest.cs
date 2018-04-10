using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Creational.FactoryPattern.WithDI;
using Unity;

namespace Vishnu.Patterns.ConsoleTest
{
    public class FactoryPatternWithDITest
    {
        public static void Perform()
        {
            var container = CompositionRoot.Configure();
            var factory = container.Resolve<IPaymentGatewayFactory>();
            IPaymentGateWay gateway = factory.Create(Gateways.Swift);
            gateway.Invoke();
            gateway = factory.Create(Gateways.WellsFargo);
            gateway.Invoke();
            gateway = factory.Create(Gateways.ProtocolBase);
            gateway.Invoke();
        }
    }
}
