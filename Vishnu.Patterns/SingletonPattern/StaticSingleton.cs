using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Version 4 : Static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, 
    /// and to execute only once per AppDomain
    /// </summary>
    public sealed class StaticSingleton
    {
        /// <summary>
        /// Class reference
        /// </summary>
        private static readonly StaticSingleton _instance = new StaticSingleton();

        /// <summary>
        /// Explicit static constrcutor to tell C# compiler 
        /// not ot mark as beforefieldinit
        /// </summary>
        static StaticSingleton()
        {
        }

        /// <summary>
        /// Prevents instance creation.
        /// </summary>
        private StaticSingleton()
        {
        }

        /// <summary>
        /// Get single instance of the class.
        /// </summary>
        public static StaticSingleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
