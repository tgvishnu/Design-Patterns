using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vishnu.Patterns.Structural.CompositePattern;

namespace Vishnu.Patterns.ConsoleTest
{
    public class CompositePatternTest
    {
        public static void Perform()
        {
            IUIControl objRoot = new UIPanel();
            objRoot.Name = "Panel1";
            IUIControl objChild1 = new UITextBox();
            objChild1.Name = "Textbox1.1";
            objRoot.CreateChild(objChild1);
            IUIControl objChild2 = new UIPanel();
            objChild2.Name = "Panel1.1";
            objRoot.CreateChild(objChild2);
            IUIControl objChild21 = new UITextBox();
            objChild21.Name = "Textbox1.1.1";
            objChild2.CreateChild(objChild21);
            IUIControl objChild22 = new UITextBox();
            objChild22.Name = "Textbox1.1.2";
            objChild2.CreateChild(objChild22);
            IUIControl objChild23 = new UITextBox();
            objChild23.Name = "Textbox1.1.3";
            objChild2.CreateChild(objChild23);
            objRoot.Render();


            Console.WriteLine();
        }
    }
}
