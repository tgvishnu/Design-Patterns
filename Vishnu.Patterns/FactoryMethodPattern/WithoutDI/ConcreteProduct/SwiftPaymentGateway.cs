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
    public class SwiftPaymentGateway : IPaymentGateWay
    {
        /// <summary>
        /// Invoide gateway functionality
        /// </summary>
        public void Invoke()
        {
            Console.WriteLine("Implement SHIFT4 logic");
        }
    }
}
