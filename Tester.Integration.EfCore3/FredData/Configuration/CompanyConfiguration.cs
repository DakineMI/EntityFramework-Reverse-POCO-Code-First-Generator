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
    // Company
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company", "dbo");
            builder.HasKey(x => x.CoId).HasName("PK_Company").IsClustered();

            builder.Property(x => x.CoId).HasColumnName(@"coID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CocogId).HasColumnName(@"cocogID").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CocuId).HasColumnName(@"cocuID").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CoName).HasColumnName(@"coName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.CoShortName).HasColumnName(@"coShortName").HasColumnType("nvarchar(50)").IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.CoHtmlName).HasColumnName(@"coHtmlName").HasColumnType("nvarchar(1000)").IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.CoEmployerNo).HasColumnName(@"coEmployerNo").HasColumnType("nvarchar(50)").IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.CoValidFrom).HasColumnName(@"coValidFrom").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CoValidTo).HasColumnName(@"coValidTo").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CoVatIdNo).HasColumnName(@"coVatIdNo").HasColumnType("nvarchar(50)").IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.CoUrl).HasColumnName(@"coURL").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.CoActive).HasColumnName(@"coActive").HasColumnType("bit").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.CompanyGroup).WithMany(b => b.Companies).HasForeignKey(c => c.CocogId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Company_CompanyGroup");
        }
    }

}
// </auto-generated>
