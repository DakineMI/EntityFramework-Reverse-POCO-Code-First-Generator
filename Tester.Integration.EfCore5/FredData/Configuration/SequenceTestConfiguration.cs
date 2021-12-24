// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // SequenceTest
    public class SequenceTestConfiguration : IEntityTypeConfiguration<SequenceTest>
    {
        public void Configure(EntityTypeBuilder<SequenceTest> builder)
        {
            builder.ToTable("SequenceTest", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__Sequence__3214EC072BABC879").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountBy1]");
            builder.Property(x => x.CntByBigInt).HasColumnName(@"CntByBigInt").HasColumnType("bigint").IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountByBigInt]");
            builder.Property(x => x.CntByTinyInt).HasColumnName(@"CntByTinyInt").HasColumnType("tinyint").IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountByTinyInt]");
            builder.Property(x => x.CntBySmallInt).HasColumnName(@"CntBySmallInt").HasColumnType("smallint").IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountBySmallInt]");
            builder.Property(x => x.CntByDecimal).HasColumnName(@"CntByDecimal").HasColumnType("decimal(18,0)").HasPrecision(18,0).IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountByDecimal]");
            builder.Property(x => x.CntByNumeric).HasColumnName(@"CntByNumeric").HasColumnType("numeric(18,0)").HasPrecision(18,0).IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountByNumeric]");
        }
    }

}
// </auto-generated>
