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
    public class WellsFargoGateway : IPaymentGateWay
    {
        /// <summary>
        /// Invoide gateway functionality
        /// </summary>
        public void Invoke()
        {
            Console.WriteLine("Implement Wells Fargo logic");
        }
    }
}
