using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Structural.CompositePattern
{
    /// <summary>
    /// Component
    /// </summary>
    public interface IUIControl
    {
        string Name { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        void Render();
        void CreateChild(IUIControl control);
        void DeleteChile(IUIControl control);
    }
}
