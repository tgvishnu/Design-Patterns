using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Abstract Product B
    /// </summary>
    public interface ISmartPhone
    {
        /// <summary>
        /// Get model details
        /// </summary>
        /// <returns>model details</returns>
        string GetModelDetails();
    }
}
