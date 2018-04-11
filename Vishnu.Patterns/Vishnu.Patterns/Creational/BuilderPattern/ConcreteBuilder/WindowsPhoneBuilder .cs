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

        public WindowsPhoneBuilder()
        {
            _phone = new MobilePhone("Windows Phone");
        }

        public MobilePhone Phone
        {
            get
            {
                return _phone;
            }
        }

        public void BuildBattery()
        {
            _phone.PhoneBattery = BatteryTypes.MAH1000;
        }

        public void BuildOperatingSystem()
        {
            _phone.PhoneOS = OperatingSystemTypes.WindowsMobile;
        }

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenTypes.TouchCapacitive;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = StylusTypes.Yes;
        }
    }
}
