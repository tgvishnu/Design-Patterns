using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.CompositePattern
{
    /// <summary>
    /// Composite control
    /// </summary>
    public class UIPanel : IUIControl
    {
        private List<IUIControl> _childControls = new List<IUIControl>();
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
            get; set;
        }

        public void CreateChild(IUIControl control)
        {
            _childControls.Add(control);
        }

        public void DeleteChile(IUIControl control)
        {
            _childControls.Remove(control);
        }

        public void Render()
        {
            Console.WriteLine("Child Control for Panel(" + Name + ")  Render start");
            foreach (IUIControl item in _childControls)
            {
                item.Render();
            }

            Console.WriteLine("Child Control for Panel(" + Name + ")  Render End");
        }
    }
}
