using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.DecoratorPattern
{
    public interface IMessageWriter
    {
        string Message { get; set; }
        string WriteMessage();
    }
}
