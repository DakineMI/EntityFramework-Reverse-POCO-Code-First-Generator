// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.co.uk/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 15 DEC 2022
//
// The following connection settings were used to generate this file:
//     Connection String Name: "FredDbContext"
//     Connection String:      "Data Source=(local);Initial Catalog=Fred;Integrated Security=True"
//
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2037.2
//
// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V3Fred
{
    // TableB
    public class TableB
    {
        public int TableBId { get; set; } // TableBId (Primary key)
        public int TableAId { get; set; } // TableAId (Primary key)
        public int? ParentTableAId { get; set; } // ParentTableAId
        public string TableBDesc { get; set; } // TableBDesc (length: 20)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) TableB pointed by [TableB].([TableAId], [TableBId]) (ParentTableB_Hierarchy)
        /// </summary>
        public virtual TableB TableB2 { get; set; } // TableB.ParentTableB_Hierarchy

        // Foreign keys

        /// <summary>
        /// Parent TableA pointed by [TableB].([TableAId]) (FK_TableA_CompositeKey_Req)
        /// </summary>
        public virtual TableA TableA_TableAId { get; set; } // FK_TableA_CompositeKey_Req

        /// <summary>
        /// Parent TableB pointed by [TableB].([TableAId], [TableBId]) (ParentTableB_Hierarchy)
        /// </summary>
        public virtual TableB TableB1 { get; set; } // ParentTableB_Hierarchy
    }

}
// </auto-generated>
