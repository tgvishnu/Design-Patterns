using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.BridgePattern
{
    public class SendSMS : SendData
    {

        public SendSMS()
        {
        }

        public SendSMS(IBridgeComponents bridgeComponent)
        {
            this.BridgeComponents = bridgeComponent;
        }

        public override void Send()
        {
            // use bridge to send message.
            this.BridgeComponents.Send("SMS");
        }
    }
}
