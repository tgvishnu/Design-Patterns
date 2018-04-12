using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.PrototypePattern
{
    public class TopupConcretePrototype : ProductPrototype
    {

        /// <summary>
        /// Creates new instance of TopupConcretePrototype class
        /// </summary>
        /// <param name="service">type of service</param>
        /// <param name="serviceOperator">service operator</param>
        /// <param name="circle">service circle</param>
        /// <param name="provider">service provider</param>
        /// <param name="serviceCommission">service comission</param>
        public TopupConcretePrototype(string service, string serviceOperator, string circle, string provider, Commission serviceCommission)
            : base(service, serviceOperator, circle, provider, serviceCommission)
        {
        }

        /// <summary>
        /// Get deep copy of the product.
        /// </summary>
        /// <returns></returns>
        public override ProductPrototype Clone()
        {
            TopupConcretePrototype cloneCopy = (TopupConcretePrototype)this.MemberwiseClone();
            cloneCopy.ServiceCommission = (Commission)this.ServiceCommission.Clone();
            return cloneCopy;
        }
    }
}
