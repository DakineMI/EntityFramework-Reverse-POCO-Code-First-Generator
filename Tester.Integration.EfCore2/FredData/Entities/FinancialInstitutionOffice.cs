// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    // FinancialInstitutionOffice
    public class FinancialInstitutionOffice
    {
        public Guid Code { get; set; } // Code
        public Guid FinancialInstitutionCode { get; set; } // FinancialInstitutionCode (Primary key via unique index UniqueOfficeName_FinancialInstitutionOffice)
        public string OfficeName { get; set; } // OfficeName (length: 200)
    }

}
// </auto-generated>
