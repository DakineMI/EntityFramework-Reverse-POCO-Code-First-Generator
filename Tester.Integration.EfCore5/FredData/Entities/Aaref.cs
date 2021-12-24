// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // AAREF
    public class Aaref
    {
        public int C1 { get; set; } // C1 (Primary key)
        public int C2 { get; set; } // C2 (Primary key)
        public DateTime CreatedUtc { get; set; } // CreatedUTC

        // Reverse navigation

        /// <summary>
        /// Child A where [A].([C1], [C2]) point to this entity (FK_A_A)
        /// </summary>
        public virtual ICollection<A> A { get; set; } // A.FK_A_A

        public Aaref()
        {
            A = new List<A>();
        }
    }

}
// </auto-generated>
