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
    // CODE_PARAM_MeetingTopicDetailSource
    public class CodeParamMeetingTopicDetailSource
    {
        public int Id { get; set; } // ID (Primary key)
        public string Code { get; set; } // Code (length: 5)
        public string Label { get; set; } // Label (length: 50)
        public string LabelEng { get; set; } // LabelENG (length: 50)
        public string LabelEsp { get; set; } // LabelESP (length: 50)
        public string LabelFra { get; set; } // LabelFRA (length: 50)
        public DateTime DateCreated { get; set; } // DateCreated
        public DateTime? DateChanged { get; set; } // DateChanged

        // Reverse navigation

        /// <summary>
        /// Child CodeMeetingTopicDetails where [CODE_MeetingTopicDetails].[origem] point to this entity (FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource)
        /// </summary>
        public virtual ICollection<CodeMeetingTopicDetail> CodeMeetingTopicDetails { get; set; } // CODE_MeetingTopicDetails.FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource

        public CodeParamMeetingTopicDetailSource()
        {
            CodeMeetingTopicDetails = new List<CodeMeetingTopicDetail>();
        }
    }

}
// </auto-generated>
