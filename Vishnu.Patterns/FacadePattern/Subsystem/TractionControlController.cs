using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.FacadePattern
{
    public class TractionControlController : ITractionControlController
    {
        public bool Enabled { get; set; }
        public void Enable()
        {
            Enabled = true;
            Console.WriteLine("Traction controled enabled");
        }
        public void Disable()
        {
            Enabled = false;
            Console.WriteLine("Traction control disabled");
        }
    }
}
