using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Structural.AdapterPattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class AdapterPatternTest
    {
        public static void Perform()
        {
            IBird _sparrow = new Sparrow();
            IToyDuck _toyDuck = new PlasticToyDuck();
            // Wrap a bird in a birdAdapter so that it 
            // behaves like toy duck
            IToyDuck _birdAdapter = new BirdAdapter(_sparrow);
            Console.WriteLine("Sparrow...");
            _sparrow.Fly();
            _sparrow.MakeSound();
            Console.WriteLine("Toy Duck");
            _toyDuck.Squeak();
            // bird behaving like a toy duck
            Console.WriteLine("BirdAdapter...");
            _birdAdapter.Squeak();
            Console.WriteLine();
        }
    }
}
