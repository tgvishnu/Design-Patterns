using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    /// <summary>
    /// Creater interface
    /// </summary>
    public interface IPaymentGatewayFactory
    {
        IPaymentGateWay Create(Gateways gatewayType);
    }
}
