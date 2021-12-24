// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // Ticket
    public class Ticket
    {
        public long Id { get; set; } // Id (Primary key)
        public long CreatedById { get; set; } // CreatedById
        public long? ModifiedById { get; set; } // ModifiedById

        // Foreign keys

        /// <summary>
        /// Parent AppUser pointed by [Ticket].([CreatedById]) (FK_Ticket_AppUser)
        /// </summary>
        public virtual AppUser CreatedBy { get; set; } // FK_Ticket_AppUser

        /// <summary>
        /// Parent AppUser pointed by [Ticket].([ModifiedById]) (FK_Ticket_AppUser1)
        /// </summary>
        public virtual AppUser ModifiedBy { get; set; } // FK_Ticket_AppUser1
    }

}
// </auto-generated>
