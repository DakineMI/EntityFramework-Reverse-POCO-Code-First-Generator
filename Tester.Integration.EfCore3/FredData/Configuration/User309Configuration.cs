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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V3Fred
{
    // User309
    public class User309Configuration : IEntityTypeConfiguration<User309>
    {
        public void Configure(EntityTypeBuilder<User309> builder)
        {
            builder.ToTable("User309", "dbo");
            builder.HasKey(x => x.UserId).HasName("PK_User309").IsClustered();

            builder.Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Lastname).HasColumnName(@"Lastname").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Firstname).HasColumnName(@"Firstname").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.PhoneCountryId).HasColumnName(@"PhoneCountryID").HasColumnType("int").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.Country).WithMany(b => b.User309).HasForeignKey(c => c.PhoneCountryId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_User309_PhoneCountry");
        }
    }

}
// </auto-generated>
