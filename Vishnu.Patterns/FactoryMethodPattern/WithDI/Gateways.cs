using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.FactoryPattern.WithDI
{
    /// <summary>
    /// Gateway types
    /// </summary>
    public enum Gateways
    {
        /// <summary>
        /// Protocol base
        /// </summary>
        ProtocolBase = 1,

        /// <summary>
        /// Swift
        /// </summary>
        Swift = 2,

        /// <summary>
        /// Wells Fargo
        /// </summary>
        WellsFargo = 3
    }
}
