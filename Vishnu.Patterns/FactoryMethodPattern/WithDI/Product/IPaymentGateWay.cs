using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    /// <summary>
    /// Product interface
    /// </summary>
    public interface IPaymentGateWay
    {
        /// <summary>
        /// Invoke gateway functionality.
        /// </summary>
        void Invoke();
    }
}
