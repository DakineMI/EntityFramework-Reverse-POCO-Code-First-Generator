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

namespace V3Fred
{
    public class StpMultipleIdenticalResultsReturnModel
    {
        public class ResultSetModel1
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public List<ResultSetModel1> ResultSet1;
        public class ResultSetModel2
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public List<ResultSetModel2> ResultSet2;
    }

}
// </auto-generated>
