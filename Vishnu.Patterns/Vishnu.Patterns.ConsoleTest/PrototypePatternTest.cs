using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Creational.PrototypePattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class PrototypePatternTest
    {
        public static void Perform()
        {
            Console.WriteLine("                  Service    Operator    Circle    Provider     InComm  OutComm");
            Console.WriteLine("");
            TopupConcretePrototype CPT1 = new TopupConcretePrototype("Topup", "All", "Gujarat", "CyberPlat", new Commission(1.0, 0.5));

            Console.WriteLine("Original Object   {0}      {1}         {2}   {3}    {4}       {5} ", CPT1.Service, CPT1.ServiceOperator, CPT1.Circle, CPT1.Provider, CPT1.ServiceCommission.IncomingCommission, CPT1.ServiceCommission.OutgoingCommission);
            Console.WriteLine("");

            TopupConcretePrototype CPT2 = (TopupConcretePrototype)CPT1.Clone();

            Console.WriteLine("Deep Copy         {0}      {1}         {2}   {3}    {4}       {5}", CPT2.Service, CPT2.ServiceOperator, CPT2.Circle, CPT2.Provider, CPT2.ServiceCommission.IncomingCommission, CPT2.ServiceCommission.OutgoingCommission);
            Console.WriteLine("");

            CPT2.Circle = "Telengana";
            CPT2.Provider = "Euronet";
            CPT2.ServiceCommission.IncomingCommission = 0.75;
            CPT2.ServiceCommission.OutgoingCommission = 0.25;

            Console.WriteLine("Change Deep       {0}      {1}         {2}   {3}    {4}       {5}", CPT2.Service, CPT2.ServiceOperator, CPT2.Circle, CPT2.Provider, CPT2.ServiceCommission.IncomingCommission, CPT2.ServiceCommission.OutgoingCommission);
            Console.WriteLine("");
            Console.WriteLine("Original Object   {0}      {1}         {2}   {3}    {4}       {5}", CPT1.Service, CPT1.ServiceOperator, CPT1.Circle, CPT1.Provider, CPT1.ServiceCommission.IncomingCommission, CPT1.ServiceCommission.OutgoingCommission);
            Console.WriteLine("");
        }
    }
}
