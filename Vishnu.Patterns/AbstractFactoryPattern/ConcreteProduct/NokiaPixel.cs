using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        /// <summary>
        /// Get model details
        /// </summary>
        /// <returns>model details</returns>
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
