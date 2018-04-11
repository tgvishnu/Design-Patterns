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
        void BuildScreen();
        void BuildBattery();
        void BuildOperatingSystem();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
}
