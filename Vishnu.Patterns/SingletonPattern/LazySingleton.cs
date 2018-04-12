using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Version 6. Lazy<T> singleton
    /// </summary>
    public sealed class LazySingleton
    {
        /// <summary>
        /// Lazy initialization
        /// </summary>
        private static readonly Lazy<LazySingleton> _lazy = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        /// Get single instance.
        /// </summary>
        public static LazySingleton Instance
        {
            get
            {
                return _lazy.Value;
            }
        }

        /// <summary>
        /// Prevents instance creation.
        /// </summary>
        private LazySingleton()
        {
        }
    }
}
