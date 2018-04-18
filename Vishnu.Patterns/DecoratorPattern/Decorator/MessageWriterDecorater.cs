using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.DecoratorPattern
{
    public abstract class MessageWriterDecorater : IMessageWriter
    {
        protected IMessageWriter _messageWriter = null;
        public string Message
        {
            get; set;
        }

        public MessageWriterDecorater(IMessageWriter messageWriter)
        {
            _messageWriter = messageWriter;
        }

        public abstract string WriteMessage();
    }
}
