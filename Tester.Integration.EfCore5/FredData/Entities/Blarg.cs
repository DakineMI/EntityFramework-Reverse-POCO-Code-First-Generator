// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // Blarg
    public class Blarg
    {
        public int BlargId { get; set; } // BlargID (Primary key)

        // Reverse navigation

        /// <summary>
        /// Child Blahs (Many-to-Many) mapped by table [BlahBlargLink]
        /// </summary>
        public virtual ICollection<Blah> Blahs { get; set; } // Many to many mapping

        public Blarg()
        {
            Blahs = new List<Blah>();
        }
    }

}
// </auto-generated>
