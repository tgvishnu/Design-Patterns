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
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        MobilePhone _phone;

        /// <summary>
        /// Creates new instance of Windows phone.
        /// </summary>
        public WindowsPhoneBuilder()
        {
            _phone = new MobilePhone("Windows Phone");
        }

        /// <summary>
        /// Get windows phone.
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
            _phone.PhoneBattery = BatteryTypes.MAH1000;
        }

        /// <summary>
        /// Build operating system.
        /// </summary>
        public void BuildOperatingSystem()
        {
            _phone.PhoneOS = OperatingSystemTypes.WindowsMobile;
        }

        /// <summary>
        /// Build screen.
        /// </summary>
        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenTypes.TouchCapacitive;
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
