using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.BuilderPattern
{
    /// <summary>
    /// Concrete phone builder
    /// </summary>
    public class AndriodPhoneBuilder : IPhoneBuilder
    {
        MobilePhone _phone;

        /// <summary>
        /// Creates new instance of AndriodPhoneBuilder class
        /// </summary>
        public AndriodPhoneBuilder()
        {
            _phone = new MobilePhone("Andriod Phone");
        }

        /// <summary>
        /// Get Andriod phone.
        /// </summary>
        public MobilePhone Phone
        {
            get
            {
                return _phone;
            }
        }

        /// <summary>
        /// Build battery.
        /// </summary>
        public void BuildBattery()
        {
            _phone.PhoneBattery = BatteryTypes.MAH1500;
        }

        /// <summary>
        /// Build operating system.
        /// </summary>
        public void BuildOperatingSystem()
        {
            _phone.PhoneOS = OperatingSystemTypes.Andriod;
        }

        /// <summary>
        /// Build screen.
        /// </summary>
        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenTypes.TouchResistive;
        }

        /// <summary>
        /// Build stylus.
        /// </summary>
        public void BuildStylus()
        {
            _phone.PhoneStylus = StylusTypes.Yes;
        }
    }
}
