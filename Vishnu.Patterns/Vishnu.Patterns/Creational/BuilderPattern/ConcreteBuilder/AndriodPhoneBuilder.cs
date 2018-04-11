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

        public AndriodPhoneBuilder()
        {
            _phone = new MobilePhone("Andriod Phone");
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
            _phone.PhoneBattery = BatteryTypes.MAH1500;
        }

        public void BuildOperatingSystem()
        {
            _phone.PhoneOS = OperatingSystemTypes.Andriod;
        }

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenTypes.TouchResistive;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = StylusTypes.Yes;
        }
    }
}
