// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // ForeignKeyIsNotEnforcedItem
    public class ForeignKeyIsNotEnforcedItem
    {
        public int Id { get; set; } // id (Primary key)
        public int? NullValue { get; set; } // null_value
        public int NotNullValue { get; set; } // not_null_value

        // Foreign keys

        /// <summary>
        /// Parent ForeignKeyIsNotEnforced pointed by [ForeignKeyIsNotEnforcedItem].([NotNullValue]) (FK_ForeignKeyIsNotEnforcedItem_notnull_notnull)
        /// </summary>
        public virtual ForeignKeyIsNotEnforced ForeignKeyIsNotEnforced_NotNullValue { get; set; } // FK_ForeignKeyIsNotEnforcedItem_notnull_notnull

        /// <summary>
        /// Parent ForeignKeyIsNotEnforced pointed by [ForeignKeyIsNotEnforcedItem].([NullValue]) (FK_ForeignKeyIsNotEnforcedItem_null_notnull)
        /// </summary>
        public virtual ForeignKeyIsNotEnforced ForeignKeyIsNotEnforced_NullValue { get; set; } // FK_ForeignKeyIsNotEnforcedItem_null_notnull
    }

}
// </auto-generated>
