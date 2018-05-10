using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Behavioral.ChainOfResponsibilityPattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class ChainOfResponsibilityPatternTest
    {
        public static void Perform()
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            Console.WriteLine();
        }
    }
}
