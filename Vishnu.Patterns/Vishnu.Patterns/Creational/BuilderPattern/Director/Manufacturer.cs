using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.BuilderPattern
{
    public class Manufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOperatingSystem();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
