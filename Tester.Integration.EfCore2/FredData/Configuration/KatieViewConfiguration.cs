// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // KatieView
    public class KatieViewConfiguration : IEntityTypeConfiguration<KatieView>
    {
        public void Configure(EntityTypeBuilder<KatieView> builder)
        {
            builder.ToTable("KatieView", "dbo");
            builder.HasKey(x => new { x.KateId, x.Description });

            builder.Property(x => x.KateId).HasColumnName(@"KateID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Description).HasColumnName(@"description").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
        }
    }

}
// </auto-generated>
