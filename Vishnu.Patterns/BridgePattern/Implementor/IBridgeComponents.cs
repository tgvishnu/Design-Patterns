using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.BridgePattern
{
    /// <summary>
    /// Abstract bridge component.
    /// </summary>
    public interface IBridgeComponents
    {
        void Send(string messageType);
    }
}
