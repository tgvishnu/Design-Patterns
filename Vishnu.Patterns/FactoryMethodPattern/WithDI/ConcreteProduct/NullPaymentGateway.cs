using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    /// <summary>
    /// Null payment gateway
    /// </summary>
    public class NullPaymentGateway : IPaymentGateWay
    {
        static Lazy<IPaymentGateWay> nullObject = new Lazy<IPaymentGateWay>(() => new NullPaymentGateway());

        /// <summary>
        /// Gets empty gateway
        /// </summary>
        public static IPaymentGateWay Empty
        {
            get { return nullObject.Value; }
        }

        /// <summary>
        /// Prevents creation of new instance of NullPyamentGateway class.
        /// </summary>
        private NullPaymentGateway()
        {
        }

        /// <summary>
        /// Invode operation.
        /// </summary>
        public void Invoke()
        {
            //No-op
        }
    }
}
