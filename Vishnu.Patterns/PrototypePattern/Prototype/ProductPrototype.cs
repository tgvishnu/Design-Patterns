using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.PrototypePattern
{
    /// <summary>
    /// Prototype
    /// </summary>
    public abstract class ProductPrototype
    {
        private string _service;
        private string _serviceOperator;
        private string _circle;
        private string _provider;
        private Commission _serviceCommission;

        /// <summary>
        /// Base class for product.
        /// </summary>
        /// <param name="service">type of service</param>
        /// <param name="serviceOperator">service operator</param>
        /// <param name="circle">service circle</param>
        /// <param name="provider">service provider</param>
        /// <param name="serviceCommission">service comission</param>
        public ProductPrototype(string service, string serviceOperator, string circle, string provider, Commission serviceCommission)
        {
            _service = service;
            _serviceOperator = serviceOperator;
            _circle = circle;
            _provider = provider;
            _serviceCommission = serviceCommission;
        }

        /// <summary>
        /// Gets or sets service type
        /// </summary>
        public string Service
        {
            get
            {
                return _service;
            }
            set
            {
                _service = value;
            }
        }

        /// <summary>
        /// Gets or sets service operator
        /// </summary>
        public string ServiceOperator
        {
            get
            {
                return _serviceOperator;
            }
            set
            {
                _serviceOperator = value;
            }
        }

        /// <summary>
        /// Gets or sets circle.
        /// </summary>
        public string Circle
        {
            get
            {
                return _circle;
            }
            set
            {
                _circle = value;
            }
        }

        /// <summary>
        /// Gets or sets provider
        /// </summary>
        public string Provider
        {
            get
            {
                return _provider;
            }
            set
            {
                _provider = value;
            }
        }

        /// <summary>
        /// Gets or sets service comission.
        /// </summary>
        public Commission ServiceCommission
        {
            get
            {
                return _serviceCommission;
            }
            set
            {
                _serviceCommission = value;
            }
        }

        public abstract ProductPrototype Clone();
    }
}
