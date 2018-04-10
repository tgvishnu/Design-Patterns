using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    public class NullPaymentGateway : IPaymentGateWay
    {
        static Lazy<IPaymentGateWay> nullObject = new Lazy<IPaymentGateWay>(() => new NullPaymentGateway());
        public static IPaymentGateWay Empty
        {
            get { return nullObject.Value; }
        }

        private NullPaymentGateway()
        {
        }

        public void Invoke()
        {
            //No-op
        }
    }
}
