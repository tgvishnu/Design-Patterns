using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Structural.FacadePattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class FacadePatternTest
    {
        public static void Perform()
        {
            VehicleFacade vehicle = new VehicleFacade(new EngineController(), new TransmissionController(),
                new TractionControlController(), new TachometerController());
            vehicle.Start();
            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Accelerate();
            }

            for (int i = 0; i < 30; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Brake();
            }

            vehicle.Off();
        }
    }
}
