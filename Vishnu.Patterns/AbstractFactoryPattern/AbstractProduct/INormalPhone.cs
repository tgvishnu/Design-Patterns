using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Abstract Product A
    /// </summary>
    public interface INormalPhone
    {
        /// <summary>
        /// Get model details
        /// </summary>
        /// <returns>model details</returns>
        string GetModelDetails();
    }
}
