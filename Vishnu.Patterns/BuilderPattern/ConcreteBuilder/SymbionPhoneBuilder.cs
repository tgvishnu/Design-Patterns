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
    public class SymbionPhoneBuilder : IPhoneBuilder
    {
        MobilePhone _phone;

        /// <summary>
        /// Creates new instance of SymbionPhoneBuilder class
        /// </summary>
        public SymbionPhoneBuilder()
        {
            _phone = new MobilePhone("Symbion Phone");
        }

        /// <summary>
        /// Get Symbion phone.
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
            _phone.PhoneBattery = BatteryTypes.MAH2000;
        }

        /// <summary>
        /// Build operating system.
        /// </summary>
        public void BuildOperatingSystem()
        {
            _phone.PhoneOS = OperatingSystemTypes.Symbian;
        }

        /// <summary>
        /// Build screen.
        /// </summary>
        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenTypes.NonTouch;
        }

        /// <summary>
        /// Build stylus.
        /// </summary>
        public void BuildStylus()
        {
            _phone.PhoneStylus = StylusTypes.No;
        }
    }
}
