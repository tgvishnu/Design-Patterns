using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.AbstractFactoryPattern
{
    /// <summary>
    /// Clinet
    /// </summary>
    public class PhoneClient
    {
        ISmartPhone _smartPhone = null;
        INormalPhone _normalPhone = null;
        public PhoneClient(IPhoneFactory phoneFactory)
        {
            _smartPhone = phoneFactory.GetSmartPhone();
            _normalPhone = phoneFactory.GetNormalPhone();
        }

        public string GetSmartPhoneDetails()
        {
            return _smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneDetails()
        {
            return _normalPhone.GetModelDetails();
        }
    }
}
