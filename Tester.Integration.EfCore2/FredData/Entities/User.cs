// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
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
