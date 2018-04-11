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

        public SymbionPhoneBuilder()
        {
            _phone = new MobilePhone("Symbion Phone");
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
            _phone.PhoneBattery = BatteryTypes.MAH2000;
        }

        public void BuildOperatingSystem()
        {
            _phone.PhoneOS = OperatingSystemTypes.Symbian;
        }

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenTypes.NonTouch;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = StylusTypes.No;
        }
    }
}
