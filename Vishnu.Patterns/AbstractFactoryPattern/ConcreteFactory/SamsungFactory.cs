using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Concrete factory 2
    /// </summary>
    public class SamsungFactory : IPhoneFactory
    {
        /// <summary>
        /// Concrete Product A
        /// </summary>
        /// <returns></returns>
        public INormalPhone GetNormalPhone()
        {
            return new SamungGuru();
        }

        /// <summary>
        /// Concrete Product B
        /// </summary>
        /// <returns></returns>
        public ISmartPhone GetSmartPhone()
        {
            return new SamungGalaxy();
        }
    }
}
