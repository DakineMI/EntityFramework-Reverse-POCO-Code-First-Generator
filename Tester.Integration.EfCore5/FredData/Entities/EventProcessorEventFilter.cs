// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // EventProcessorEventFilter
    public class EventProcessorEventFilter
    {
        public int Id { get; set; } // Id (Primary key)
        public int EventProcessorId { get; set; } // EventProcessorId
        public int WantedEventId { get; set; } // WantedEventId

        // Foreign keys

        /// <summary>
        /// Parent EventProcessor pointed by [EventProcessorEventFilter].([EventProcessorId]) (FK_EventProcessorEventFilter__EventProcessor)
        /// </summary>
        public virtual EventProcessor EventProcessor { get; set; } // FK_EventProcessorEventFilter__EventProcessor
    }

}
// </auto-generated>
