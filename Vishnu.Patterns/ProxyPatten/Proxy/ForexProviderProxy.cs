using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.ProxyPattern
{
    public class ForexProviderProxy : IForexProvider
    {
        private ForexProvider forexProvider;

        public bool Authenticate(string pwd)
        {
            if (forexProvider == null)
                forexProvider = new ForexProvider();
            return forexProvider.Authenticate(pwd);
        }

        public string GetPrice(string currencyName)
        {
            if (forexProvider == null)
                forexProvider = new ForexProvider();
            return forexProvider.GetPrice(currencyName);
        }

        public string Request()
        {
            if (forexProvider == null)
                forexProvider = new ForexProvider();
            return forexProvider.Request();
        }

        public string SetPrice(string currencyName, int value)
        {
            if (forexProvider == null)
                forexProvider = new ForexProvider();
            return forexProvider.SetPrice(currencyName, value);
        }
    }
}
