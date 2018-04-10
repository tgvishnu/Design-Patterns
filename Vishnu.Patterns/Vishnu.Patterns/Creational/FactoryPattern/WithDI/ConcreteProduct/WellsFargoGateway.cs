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
        public void Invoke()
        {
            Console.WriteLine("Implement Wells Fargo logic");
        }
    }
}
