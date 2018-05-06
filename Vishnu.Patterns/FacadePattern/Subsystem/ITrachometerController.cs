using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.FacadePattern
{
    public interface ITachometerController
    {
        int Rpm { get; set; }
        int Limit { get; }
    }
}
