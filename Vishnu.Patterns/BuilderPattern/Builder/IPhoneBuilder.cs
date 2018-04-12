using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.BuilderPattern
{
    /// <summary>
    /// Builder class
    /// </summary>
    public interface IPhoneBuilder
    {
        /// <summary>
        /// Build screen
        /// </summary>
        void BuildScreen();

        /// <summary>
        /// Build battery
        /// </summary>
        void BuildBattery();

        /// <summary>
        /// Build operating system.
        /// </summary>
        void BuildOperatingSystem();

        /// <summary>
        /// Build stylus
        /// </summary>
        void BuildStylus();

        /// <summary>
        /// Get mobile phone.
        /// </summary>
        MobilePhone Phone { get; }
    }
}
