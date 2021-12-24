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
    // User
    public class User
    {
        public int Id { get; set; } // ID (Primary key)
        public string ExternalUserId { get; set; } // ExternalUserID (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child UserDocuments where [User_Document].[CreatedByUserID] point to this entity (FK_User_Document_User1)
        /// </summary>
        public virtual ICollection<UserDocument> UserDocuments_CreatedByUserId { get; set; } // User_Document.FK_User_Document_User1

        /// <summary>
        /// Child UserDocuments where [User_Document].[UserID] point to this entity (FK_User_Document_User)
        /// </summary>
        public virtual ICollection<UserDocument> UserDocuments_UserId { get; set; } // User_Document.FK_User_Document_User

        public User()
        {
            UserDocuments_CreatedByUserId = new List<UserDocument>();
            UserDocuments_UserId = new List<UserDocument>();
        }
    }

}
// </auto-generated>
