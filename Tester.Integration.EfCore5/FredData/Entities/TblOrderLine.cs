// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // tblOrderLines
    public class TblOrderLine
    {
        public int Id { get; set; } // ID (Primary key)
        public int OrderId { get; set; } // OrderID
        public string Sku { get; set; } // sku (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent TblOrder pointed by [tblOrderLines].([OrderId]) (tblOrdersFK)
        /// </summary>
        public virtual TblOrder TblOrder { get; set; } // tblOrdersFK
    }

}
// </auto-generated>
