// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    // view with space
    public class ViewWithSpace
    {
        public int CodeObjectNo { get; set; } // codeObjectNo (Primary key)
        public int? ApplicationNo { get; set; } // applicationNo
        public int Type { get; set; } // type (Primary key)
        public string EName { get; set; } // eName (Primary key) (length: 250)
        public string AName { get; set; } // aName (length: 250)
        public string Description { get; set; } // description (length: 250)
        public string CodeName { get; set; } // codeName (length: 250)
        public string Note { get; set; } // note (length: 250)
        public bool IsObject { get; set; } // isObject (Primary key)
        public byte[] VersionNumber { get; set; } // versionNumber
    }

}
// </auto-generated>
