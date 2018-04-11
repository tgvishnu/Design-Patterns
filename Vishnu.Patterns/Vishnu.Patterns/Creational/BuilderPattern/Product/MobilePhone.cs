using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.BuilderPattern
{
    public class MobilePhone
    {
        string _phoneName;
        ScreenTypes _phoneScreen;
        BatteryTypes _phoneBattery;
        OperatingSystemTypes _phoneOS;
        StylusTypes _phoneStylus;

        public MobilePhone(string name)
        {
            _phoneName = name;
        }

        public string PhoneName
        {
            get
            {
                return _phoneName;
            }
        }

        public ScreenTypes PhoneScreen
        {
            get
            {
                return _phoneScreen;
            }
            set
            {
                _phoneScreen = value;
            }
        }

        public BatteryTypes PhoneBattery
        {
            get
            {
                return _phoneBattery;
            }
            set
            {
                _phoneBattery = value;
            }
        }

        public OperatingSystemTypes PhoneOS
        {
            get
            {
                return _phoneOS;
            }
            set
            {
                _phoneOS = value;
            }
        }

        public StylusTypes PhoneStylus
        {
            get
            {
                return _phoneStylus;
            }
            set
            {
                _phoneStylus = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
                this.PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);
        }
    }
}
