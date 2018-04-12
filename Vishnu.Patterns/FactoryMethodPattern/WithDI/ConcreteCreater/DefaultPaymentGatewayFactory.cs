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

        /// <summary>
        /// Creates new instance of Default payment gateway
        /// </summary>
        /// <param name="factoryFactory">delegate of facotry</param>
        public DefaultPaymentGatewayFactory(Func<Gateways, IPaymentGateWay> factoryFactory)
        {
            _factoryFactory = factoryFactory;
        }

        /// <summary>
        /// Create instance of Gateway
        /// </summary>
        /// <param name="gatewayType">gateways type</param>
        /// <returns>IPaymentGateWay</returns>
        public IPaymentGateWay Create(Gateways gatewayType)
        {
            return _factoryFactory(gatewayType);
        }
    }
}
