using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Concrete Factory 1
    /// </summary>
    public class NokiaFactory : IPhoneFactory
    {
        /// <summary>
        /// Concrete Product A
        /// </summary>
        /// <returns></returns>
        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }

        /// <summary>
        /// Concrete Product B
        /// </summary>
        /// <returns></returns>
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
