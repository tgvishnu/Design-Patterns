using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.FacadePattern
{
    public class TransmissionController : ITransmissionController
    {
        public int Gear { get; set; }
        public int MaxGear { get; set; }

        public TransmissionController()
            : this (5)
        {
        }

        public TransmissionController(int maxGear)
        {
            MaxGear = 5;
        }

        public void ShiftUp()
        {
            if(Gear < MaxGear)
            {
                Gear++;
                Console.WriteLine(string.Format("Shifted up to gear {0}", Gear));
            }
        }
        public void ShiftDown()
        {
            if (Gear > 0)
            {
                Gear--;
                Console.WriteLine(string.Format("Shifted down to gear {0}", Gear));
            }
        }
    }
}
