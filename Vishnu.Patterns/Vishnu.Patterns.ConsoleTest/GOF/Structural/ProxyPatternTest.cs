using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Structural.ProxyPattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class ProxyPatternTest
    {
        public static void Perform()
        {
            IForexProvider forex = new ForexProviderProxy();
            Console.WriteLine( forex.Request());
            forex.SetPrice("Indian Rupee", 65);
            Console.WriteLine();
        }
    }
}
