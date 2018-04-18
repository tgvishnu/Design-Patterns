using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.DecoratorPattern
{
    public class MessageWriter : IMessageWriter
    {
        public string Message
        {
            get; set;
        }

        public string WriteMessage()
        {
            return "MessageWriter : " + Message;
        }
    }
}
