using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Structural.BridgePattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class BridgePatternTest
    {
        public static void Perform()
        {
            SendData sendData = new SendEmail(new WebService());
            sendData.Send();
            sendData.BridgeComponents = new ThirdPartyAPI();
            sendData.Send();

            sendData = new SendSMS(new WebService());
            sendData.Send();
            sendData.BridgeComponents = new ThirdPartyAPI();
            sendData.Send();

            Console.WriteLine();
        }
    }
}
