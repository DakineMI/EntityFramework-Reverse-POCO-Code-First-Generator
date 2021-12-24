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
    // AAREF
    public class AarefConfiguration : IEntityTypeConfiguration<Aaref>
    {
        public void Configure(EntityTypeBuilder<Aaref> builder)
        {
            builder.ToTable("AAREF", "dbo");
            builder.HasKey(x => new { x.C1, x.C2 }).HasName("PK_AREF").IsClustered();

            builder.Property(x => x.C1).HasColumnName(@"C1").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.C2).HasColumnName(@"C2").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CreatedUtc).HasColumnName(@"CreatedUTC").HasColumnType("datetime2").IsRequired();
        }
    }

}
// </auto-generated>
