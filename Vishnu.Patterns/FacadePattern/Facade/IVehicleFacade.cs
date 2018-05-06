using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.FacadePattern
{
    public interface IVehicleFacade
    {
        void Start();
        void Accelerate();
        void Brake();
        void Off();
    }
}
