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
    // CODE_MeetingTopicDetails
    public class CodeMeetingTopicDetail
    {
        public int Id { get; set; } // id (Primary key)
        public int IdReuniao { get; set; } // id_reuniao
        public int? OrdTrab { get; set; } // ord_trab
        public string Assunto { get; set; } // assunto (length: 250)
        public string Desenvolvimento { get; set; } // desenvolvimento
        public string Origem { get; set; } // origem (length: 5)
        public int? IdOrigem { get; set; } // id_origem
        public int? Estado { get; set; } // Estado
        public int CompanyId { get; set; } // CompanyID
        public DateTime DateCreated { get; set; } // DateCreated
        public DateTime? DateChanged { get; set; } // DateChanged

        // Foreign keys

        /// <summary>
        /// Parent CodeParamMeetingTopicDetailSource pointed by [CODE_MeetingTopicDetails].([Origem]) (FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource)
        /// </summary>
        public virtual CodeParamMeetingTopicDetailSource CodeParamMeetingTopicDetailSource { get; set; } // FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource
    }

}
// </auto-generated>
