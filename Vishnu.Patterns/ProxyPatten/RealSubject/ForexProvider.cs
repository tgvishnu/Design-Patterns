using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.ProxyPattern
{
    public class ForexProvider
    {
        private bool isAutheticated;
        public string Request()
        {
            return "Request completed";
        }

        public string GetPrice(string currencyName)
        {
            return string.Format("The forex rate is {0} for {1}", 23, currencyName);
        }

        public string SetPrice(string currencyName, int value)
        {
            if (isAutheticated)
                return string.Format("The forex rate of {0} is set to {1}", currencyName, value);
            else
                return string.Format("Please autheticate yourself");
        }

        public bool Authenticate(string pwd)
        {
            if (pwd == "pwd")
            {
                isAutheticated = true;
                return true;
            }
            else
                return false;
        }
    }
}
