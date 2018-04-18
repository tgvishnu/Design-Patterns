using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Structural.DecoratorPattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class DecoratorPatternTest
    {
        public static void Perform()
        {
            IMessageWriter normalWriter = new MessageWriter();
            normalWriter.Message = "message";
            Console.WriteLine("NormalWriter => " + normalWriter.WriteMessage());
            EncryptedMessageWriter encWriter = new EncryptedMessageWriter(normalWriter);
            Console.WriteLine("encryptedWriter => " + encWriter.WriteMessage());
            SecureMessageWriter securedWriter = new SecureMessageWriter(normalWriter);
            Console.WriteLine("SecuredWriter => " + securedWriter.WriteMessage());
            SecureMessageWriter esWriter = new SecureMessageWriter(encWriter);
            Console.WriteLine("Sec, Enc Writer => " + securedWriter.WriteMessage());
            Console.WriteLine();
        }
    }
}
