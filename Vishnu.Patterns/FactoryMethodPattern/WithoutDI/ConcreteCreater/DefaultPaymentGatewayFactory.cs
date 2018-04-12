using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithoutDI
{
    /// <summary>
    /// ConcreteCreater
    /// </summary>
    public class DefaultPaymentGatewayFactory : IPaymentGatewayFactory
    {
        /// <summary>
        /// Create instance of Gateway
        /// </summary>
        /// <param name="gatewayType">gateways type</param>
        /// <returns>IPaymentGateWay</returns>
        public IPaymentGateWay Create(Gateways gatewayType)
        {
            IPaymentGateWay result = null;
            switch(gatewayType)
            {
                case Gateways.ProtocolBase:
                    result = new ProtocolBasePaymentGateway();
                    break;
                case Gateways.Swift:
                    result = new SwiftPaymentGateway();
                    break;
                case Gateways.WellsFargo:
                    result =  new WellsFargoGateway();
                    break;
                default:
                    result = NullPaymentGateway.Empty;
                    break;
            }

            return result;
        }
    }
}
