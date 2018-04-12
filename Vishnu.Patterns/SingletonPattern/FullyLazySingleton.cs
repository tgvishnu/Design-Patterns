using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Version 5 : Fully lazy singleton
    /// Instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. 
    /// This means the implementation is fully lazy. Note that although nested classes have access to the enclosing class's private members,
    /// the reverse is not true, hence the need for instance to be internal here. That doesn't raise any other problems,
    /// though, as the class itself is private. 
    /// </summary>
    public sealed class FullyLazySingleton
    {
        /// <summary>
        /// Prevents creation of new instance of class.
        /// </summary>
        private FullyLazySingleton()
        {
        }

        public static FullyLazySingleton Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly FullyLazySingleton Instance = new FullyLazySingleton();
        }
    }
}
