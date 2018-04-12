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

        /// <summary>
        /// Creates new instance of Phone Client class
        /// </summary>
        /// <param name="phoneFactory"></param>
        public PhoneClient(IPhoneFactory phoneFactory)
        {
            _smartPhone = phoneFactory.GetSmartPhone();
            _normalPhone = phoneFactory.GetNormalPhone();
        }

        /// <summary>
        /// Get smart phone details
        /// </summary>
        /// <returns>phone details</returns>
        public string GetSmartPhoneDetails()
        {
            return _smartPhone.GetModelDetails();
        }

        /// <summary>
        /// Get normal phone details
        /// </summary>
        /// <returns>phone deatils</returns>
        public string GetNormalPhoneDetails()
        {
            return _normalPhone.GetModelDetails();
        }
    }
}
