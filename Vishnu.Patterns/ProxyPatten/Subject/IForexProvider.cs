using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.ProxyPattern
{
    public interface IForexProvider
    {
        string Request();
        string GetPrice(string currencyName);
        string SetPrice(string currencyName, int value);
        bool Authenticate(string pwd);
    }
}
