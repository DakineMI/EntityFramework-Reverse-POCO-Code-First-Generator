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
    // ComplexView
    public class ComplexViewConfiguration : IEntityTypeConfiguration<ComplexView>
    {
        public void Configure(EntityTypeBuilder<ComplexView> builder)
        {
            builder.ToView("ComplexView", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.LicenseType).HasColumnName(@"LicenseType").HasColumnType("nvarchar(128)").IsRequired().HasMaxLength(128);
            builder.Property(x => x.Count).HasColumnName(@"Count").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>
