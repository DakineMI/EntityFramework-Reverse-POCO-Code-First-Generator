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
    // CV
    public class FFRS_CvConfiguration : IEntityTypeConfiguration<FFRS_Cv>
    {
        public void Configure(EntityTypeBuilder<FFRS_Cv> builder)
        {
            builder.ToTable("CV", "FFRS");
            builder.HasKey(x => new { x.BatchUid, x.Cvid });

            builder.Property(x => x.BatchUid).HasColumnName(@"BatchUID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Cvid).HasColumnName(@"CVID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CvName).HasColumnName(@"CVName").HasColumnType("nvarchar(200)").IsRequired(false).HasMaxLength(200);
        }
    }

}
// </auto-generated>
