using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithoutDI
{
    /// <summary>
    /// Product interface
    /// </summary>
    public interface IPaymentGateWay
    {
        void Invoke();
    }
}
