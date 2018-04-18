using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.DecoratorPattern
{
    public class SecureMessageWriter : MessageWriterDecorater
    {

        public SecureMessageWriter(IMessageWriter messageWriter)
            : base(messageWriter)
        {
            this.Message = "Secured :";
        }


        public override string WriteMessage()
        {
            if (IsSecured())
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
            else
            {
                return "Message not written as it is not secured";
            }
        }

        /// <summary>
        ///  Is Secured
        /// </summary>
        /// <returns>true or false</returns>
        private bool IsSecured()
        {
            return true;
        }
    }
}
