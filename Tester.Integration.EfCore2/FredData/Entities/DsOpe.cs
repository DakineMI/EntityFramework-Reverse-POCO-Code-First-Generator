// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    // DSOpe
    public class DsOpe
    {
        public int Id { get; set; } // ID (Primary key)
        public decimal DecimalDefault { get; set; } // decimal_default
        public Guid MyGuid { get; set; } // MyGuid
        public string @Default { get; set; } // default (length: 10)
        public Guid? MyGuidBadDefault { get; set; } // MyGuidBadDefault

        public DsOpe()
        {
            DecimalDefault = 99.99m;
            MyGuid = Guid.Parse("9B7E1F67-5A81-4277-BC7D-06A3262A5C70");
            MyGuidBadDefault = null;
        }
    }

}
// </auto-generated>
