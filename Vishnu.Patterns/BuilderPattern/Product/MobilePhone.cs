using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.BuilderPattern
{
    /// <summary>
    /// Mobile phone product
    /// </summary>
    public class MobilePhone
    {
        string _phoneName;
        ScreenTypes _phoneScreen;
        BatteryTypes _phoneBattery;
        OperatingSystemTypes _phoneOS;
        StylusTypes _phoneStylus;

        /// <summary>
        /// Creates new instance of mobile phone.
        /// </summary>
        /// <param name="name">phone name</param>
        public MobilePhone(string name)
        {
            _phoneName = name;
        }

        /// <summary>
        /// Gets phone name.
        /// </summary>
        public string PhoneName
        {
            get
            {
                return _phoneName;
            }
        }

        /// <summary>
        /// Gets or sets screen type.
        /// </summary>
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

        /// <summary>
        /// Gets or sets phone battery.
        /// </summary>
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

        /// <summary>
        /// Gets or sets operating system.
        /// </summary>
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

        /// <summary>
        /// Gets or sets phone stylus.
        /// </summary>
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

        /// <summary>
        /// Get phone details
        /// </summary>
        /// <returns>details</returns>
        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
                this.PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);
        }
    }
}
