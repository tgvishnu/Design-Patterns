using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.AdapterPattern
{
    /// <summary>
    /// Bird interface 
    /// </summary>
    public interface IBird
    {
        string Fly();
        string MakeSound();
    }
}
