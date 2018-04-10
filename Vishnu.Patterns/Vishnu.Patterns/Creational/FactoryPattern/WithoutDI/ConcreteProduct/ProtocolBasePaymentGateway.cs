using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithoutDI
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class ProtocolBasePaymentGateway : IPaymentGateWay
    {
        public void Invoke()
        {
            Console.WriteLine("Implement Protobase logic");
        }
    }
}
