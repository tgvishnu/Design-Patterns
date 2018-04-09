using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Version 2: Simple thread safe singleton class.
    /// This implementation is thread-safe. 
    /// The thread takes out a lock on a shared object, and then checks whether or not the instance has been created before creating the instance. 
    /// This takes care of the memory barrier issue and ensures that only one thread will create an instance 
    /// Unfortunately, performance suffers as a lock is acquired every time the instance is requested
    /// </summary>
    public sealed class SimpleThreadSafeSingleton
    {
        /// <summary>
        /// class instance
        /// </summary>
        private static SimpleThreadSafeSingleton _instance = null;
        
        /// <summary>
        /// locker object
        /// </summary>
        private static readonly object _instanceLocker = new object();

        /// <summary>
        /// Prevents creation of new instance of class.
        /// </summary>
        private SimpleThreadSafeSingleton()
        {
        }

        /// <summary>
        /// Get single instance of the class.
        /// </summary>
        public static SimpleThreadSafeSingleton Instance
        {
            get
            {
                lock(_instance)
                {
                    if(_instance == null)
                    {
                        _instance = new SimpleThreadSafeSingleton();
                    }

                    return _instance;
                }
            }
        }
    }
}
