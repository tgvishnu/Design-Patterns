using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    public static class CompositionRoot
    {
        public static IUnityContainer Configure()
        {
            var container = new UnityContainer();
            // register gateways by mapping
            container.RegisterType<IPaymentGateWay, WellsFargoGateway>(Gateways.WellsFargo.ToString());
            container.RegisterType<IPaymentGateWay, SwiftPaymentGateway>(Gateways.Swift.ToString());
            container.RegisterType<IPaymentGateWay, ProtocolBasePaymentGateway>(Gateways.ProtocolBase.ToString());
            // create a strategy
            Func<Gateways, IPaymentGateWay> factoryFactory = (gatewayType) =>
                container.Resolve<IPaymentGateWay>(gatewayType.ToString()) ?? NullPaymentGateway.Empty;
            var factory = new DefaultPaymentGatewayFactory(factoryFactory);
            // register factory
            container.RegisterInstance<IPaymentGatewayFactory>(factory);
            return container;
        }
    }
}
