using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.DecoratorPattern
{
    public class EncryptedMessageWriter : MessageWriterDecorater
    {

        public EncryptedMessageWriter(IMessageWriter messageWriter)
            : base(messageWriter)
        {
            this.Message = "Encrypted : ";
        }


        public override string WriteMessage()
        {
            return this.Encrypt();
        }

        private string Encrypt()
        {
            if (_messageWriter != null)
            {
                return this.Message + _messageWriter.WriteMessage();
            }
            else
            {
                return this.Message;
            }
        }
    }
}
