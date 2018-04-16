using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.AdapterPattern
{
    /// <summary>
    /// Platic Toy concrete
    /// </summary>
    public class PlasticToyDuck : IToyDuck
    {
        public string Squeak()
        {
            return "Plastic toy duck can Squeak";
        }
    }
}
