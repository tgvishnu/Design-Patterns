using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Abstract factory interface
    /// </summary>
    public interface IPhoneFactory
    {
        /// <summary>
        /// Abstract product A
        /// </summary>
        /// <returns></returns>
        INormalPhone GetNormalPhone();
        /// <summary>
        /// Abstract product B
        /// </summary>
        /// <returns></returns>
        ISmartPhone GetSmartPhone();
    }
}
