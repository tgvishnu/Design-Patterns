using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Version 1 : Non thread safe Simple singleton class.
    /// This is not thread-safe. Two different threads could both have evaluated the test if (instance==null) 
    /// and found it to be true, then both create instances, which violates the singleton pattern. 
    /// Note that in fact the instance may already have been created before the expression is evaluated, 
    /// but the memory model doesn't guarantee that the new value of instance 
    /// will be seen by other threads unless suitable memory barriers have been passed
    /// </summary>
    public sealed class SimpleSingleton
    {
        /// <summary>
        /// Class instance
        /// </summary>
        private static SimpleSingleton _instance = null;

        /// <summary>
        /// Prevents creation of new instance of the class.
        /// </summary>
        private SimpleSingleton()
        {
        }

        /// <summary>
        /// Get single instance of the class.
        /// </summary>
        public static SimpleSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SimpleSingleton();
                }

                return _instance;
            }
        }
    }
}
