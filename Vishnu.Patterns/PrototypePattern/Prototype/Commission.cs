using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Creational.PrototypePattern
{
    /// <summary>
    /// Commission details
    /// </summary>
    public class Commission : ICloneable
    {
        /// <summary>
        /// Gets or sets incoming commission
        /// </summary>
        public double IncomingCommission { get; set; }

        /// <summary>
        /// Gets or sets outgoing commission.
        /// </summary>
        public double OutgoingCommission { get; set; }

        /// <summary>
        /// Creates new instance of Commission class
        /// </summary>
        /// <param name="incomingCommission">incoming commission</param>
        /// <param name="outgoingCommission">outgoing comission</param>
        public Commission(double incomingCommission, double outgoingCommission)
        {
            this.IncomingCommission = incomingCommission;
            this.OutgoingCommission = outgoingCommission;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
