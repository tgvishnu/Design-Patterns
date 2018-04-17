using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.BridgePattern
{
    public abstract class SendData
    {
        public IBridgeComponents BridgeComponents;

        public SendData()
        {
        }


        public abstract void Send();
    }
}
