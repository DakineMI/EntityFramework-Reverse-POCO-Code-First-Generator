// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // BitFiddlerCURRENCIES
    public class BitFiddlerCurrenCyConfiguration : IEntityTypeConfiguration<BitFiddlerCurrenCy>
    {
        public void Configure(EntityTypeBuilder<BitFiddlerCurrenCy> builder)
        {
            builder.ToTable("BitFiddlerCURRENCIES", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__BitFiddl__3214EC07D56DB345").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>
