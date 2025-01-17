// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // footer
    public class FooterConfiguration : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> builder)
        {
            builder.ToTable("footer", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_footer").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.OtherId).HasColumnName(@"otherID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Added).HasColumnName(@"added").HasColumnType("datetime").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Header).WithMany(b => b.Footers).HasForeignKey(c => new { c.Id, c.OtherId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fooderFK");
        }
    }

}
// </auto-generated>
