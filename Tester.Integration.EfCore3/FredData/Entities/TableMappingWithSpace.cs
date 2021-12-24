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
    // table mapping with space
    public class TableMappingWithSpace
    {
        public int Id { get; set; } // id (Primary key)
        public int IdValue { get; set; } // id value (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TableWithSpace pointed by [table mapping with space].([Id]) (space1FK)
        /// </summary>
        public virtual TableWithSpace TableWithSpace { get; set; } // space1FK

        /// <summary>
        /// Parent TableWithSpaceAndInColumn pointed by [table mapping with space].([IdValue]) (space2FK)
        /// </summary>
        public virtual TableWithSpaceAndInColumn TableWithSpaceAndInColumn { get; set; } // space2FK
    }

}
// </auto-generated>
