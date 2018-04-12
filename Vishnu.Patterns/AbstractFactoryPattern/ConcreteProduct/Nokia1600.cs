using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class Nokia1600 : INormalPhone
    {
        /// <summary>
        /// Get model details
        /// </summary>
        /// <returns>model details</returns>
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
