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
    // rov_ColumnDefinitions
    public class dcg_RovColumnDefinitionConfiguration : IEntityTypeConfiguration<dcg_RovColumnDefinition>
    {
        public void Configure(EntityTypeBuilder<dcg_RovColumnDefinition> builder)
        {
            builder.ToView("rov_ColumnDefinitions", "dcg");
            builder.HasNoKey();

            builder.Property(x => x.TableCatalog).HasColumnName(@"TABLE_CATALOG").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.TableSchema).HasColumnName(@"TABLE_SCHEMA").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.TableName).HasColumnName(@"TABLE_NAME").HasColumnType("nvarchar(128)").IsRequired().HasMaxLength(128);
            builder.Property(x => x.ColumnName).HasColumnName(@"COLUMN_NAME").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.OrdinalPosition).HasColumnName(@"ORDINAL_POSITION").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ColumnDefault).HasColumnName(@"COLUMN_DEFAULT").HasColumnType("nvarchar(4000)").IsRequired(false).HasMaxLength(4000);
            builder.Property(x => x.IsNullable).HasColumnName(@"IS_NULLABLE").HasColumnType("varchar(3)").IsRequired(false).IsUnicode(false).HasMaxLength(3);
            builder.Property(x => x.DataType).HasColumnName(@"DATA_TYPE").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.CharacterMaximumLength).HasColumnName(@"CHARACTER_MAXIMUM_LENGTH").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CharacterOctetLength).HasColumnName(@"CHARACTER_OCTET_LENGTH").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.NumericPrecision).HasColumnName(@"NUMERIC_PRECISION").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.NumericPrecisionRadix).HasColumnName(@"NUMERIC_PRECISION_RADIX").HasColumnType("smallint").IsRequired(false);
            builder.Property(x => x.NumericScale).HasColumnName(@"NUMERIC_SCALE").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DatetimePrecision).HasColumnName(@"DATETIME_PRECISION").HasColumnType("smallint").IsRequired(false);
            builder.Property(x => x.CharacterSetCatalog).HasColumnName(@"CHARACTER_SET_CATALOG").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.CharacterSetSchema).HasColumnName(@"CHARACTER_SET_SCHEMA").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.CharacterSetName).HasColumnName(@"CHARACTER_SET_NAME").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.CollationCatalog).HasColumnName(@"COLLATION_CATALOG").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.CollationSchema).HasColumnName(@"COLLATION_SCHEMA").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.CollationName).HasColumnName(@"COLLATION_NAME").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.DomainCatalog).HasColumnName(@"DOMAIN_CATALOG").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.DomainSchema).HasColumnName(@"DOMAIN_SCHEMA").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.DomainName).HasColumnName(@"DOMAIN_NAME").HasColumnType("nvarchar(128)").IsRequired(false).HasMaxLength(128);
            builder.Property(x => x.Type).HasColumnName(@"TYPE").HasColumnType("char(2)").HasConversion(new ValueConverter<string, string>(v => v.TrimEnd(), v => v.TrimEnd())).IsRequired(false).IsFixedLength().IsUnicode(false).HasMaxLength(2);
        }
    }

}
// </auto-generated>
