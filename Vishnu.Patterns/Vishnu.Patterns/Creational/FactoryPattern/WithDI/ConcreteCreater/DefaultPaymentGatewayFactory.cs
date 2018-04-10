using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    /// <summary>
    /// ConcreteCreater
    /// </summary>
    public class DefaultPaymentGatewayFactory : IPaymentGatewayFactory
    {
        readonly Func<Gateways, IPaymentGateWay> _factoryFactory;

        public DefaultPaymentGatewayFactory(Func<Gateways, IPaymentGateWay> factoryFactory)
        {
            _factoryFactory = factoryFactory;
        }

        public IPaymentGateWay Create(Gateways gatewayType)
        {
            return _factoryFactory(gatewayType);
        }
    }
}
