using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.AdapterPattern
{
    /// <summary>
    /// Sparrow Concrete
    /// </summary>
    public class Sparrow : IBird
    {
        public string Fly()
        {
            return "Sparrow can Fly";
        }

        public string MakeSound()
        {
            return "Saprrow can make sound";
        }
    }
}
