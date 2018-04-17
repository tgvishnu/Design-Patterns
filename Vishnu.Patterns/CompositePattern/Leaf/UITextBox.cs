using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.CompositePattern
{
    /// <summary>
    /// Leaf control
    /// </summary>
    public class UITextBox : IUIControl
    {
        public int Height
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public int Width
        {
            get;set;
        }

        public void CreateChild(IUIControl control)
        {
            throw new Exception("Adding Child Control to Textbox is not possible");
        }

        public void DeleteChile(IUIControl control)
        {
            throw new Exception("Removing Child Control from Textbox is not possible");
        }

        public void Render()
        {
            Console.WriteLine("Textbox(" + Name + ") Rendered");
        }
    }
}
