using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class ProtocolBasePaymentGateway : IPaymentGateWay
    {
        /// <summary>
        /// Invoide gateway functionality
        /// </summary>
        public void Invoke()
        {
            Console.WriteLine("Implement Protobase logic");
        }
    }
}
