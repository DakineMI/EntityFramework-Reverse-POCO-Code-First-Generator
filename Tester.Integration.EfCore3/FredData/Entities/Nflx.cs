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
    // The table 'NFLX' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // NFLX
    public class Nflx
    {
        public string Date { get; set; } // Date (length: 50)
        public string Open { get; set; } // Open (length: 50)
        public string High { get; set; } // High (length: 50)
        public string Low { get; set; } // Low (length: 50)
        public string Close { get; set; } // Close (length: 50)
        public string AdjClose { get; set; } // Adj Close (length: 50)
        public string Volume { get; set; } // Volume (length: 50)
    }

}
// </auto-generated>
