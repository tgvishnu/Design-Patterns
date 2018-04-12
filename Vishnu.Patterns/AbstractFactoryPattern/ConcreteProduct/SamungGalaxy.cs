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
    public class SamungGalaxy : ISmartPhone
    {
        /// <summary>
        /// Get model details
        /// </summary>
        /// <returns>model details</returns>
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n"; 
        }
    }
}
