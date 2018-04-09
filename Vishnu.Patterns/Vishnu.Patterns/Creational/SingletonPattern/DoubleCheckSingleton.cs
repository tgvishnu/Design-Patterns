using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Version 3 : Double check thread safety singleton.
    /// This implementation attempts to be thread-safe without the necessity of taking out a lock every time. 
    /// </summary>
    public sealed class DoubleCheckSingleton
    {
        /// <summary>
        /// class instance
        /// </summary>
        private static volatile DoubleCheckSingleton _instance = null;

        /// <summary>
        /// locker object
        /// </summary>
        private static readonly object _instanceLocker = new object();

        /// <summary>
        /// Prevents creation of new instance of class.
        /// </summary>
        private DoubleCheckSingleton()
        {
        }

        /// <summary>
        /// Get single instance of the class.
        /// </summary>
        public static DoubleCheckSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instance)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
