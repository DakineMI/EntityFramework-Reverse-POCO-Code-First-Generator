// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5Fred
{
    // Company
    public class Company
    {
        public int CoId { get; set; } // coID (Primary key)
        public int? CocogId { get; set; } // cocogID
        public int? CocuId { get; set; } // cocuID
        public string CoName { get; set; } // coName (length: 255)
        public string CoShortName { get; set; } // coShortName (length: 50)
        public string CoHtmlName { get; set; } // coHtmlName (length: 1000)
        public string CoEmployerNo { get; set; } // coEmployerNo (length: 50)
        public DateTime? CoValidFrom { get; set; } // coValidFrom
        public DateTime? CoValidTo { get; set; } // coValidTo
        public string CoVatIdNo { get; set; } // coVatIdNo (length: 50)
        public string CoUrl { get; set; } // coURL (length: 255)
        public bool CoActive { get; set; } // coActive

        // Foreign keys

        /// <summary>
        /// Parent CompanyGroup pointed by [Company].([CocogId]) (FK_Company_CompanyGroup)
        /// </summary>
        public virtual CompanyGroup CompanyGroup { get; set; } // FK_Company_CompanyGroup

        public Company()
        {
            CoActive = false;
        }
    }

}
// </auto-generated>
