// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // AB_OrdersAB_
    public class AbOrdersAbConfiguration : IEntityTypeConfiguration<AbOrdersAb>
    {
        public void Configure(EntityTypeBuilder<AbOrdersAb> builder)
        {
            builder.ToTable("AB_OrdersAB_", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__AB_Order__3214EC27DCF8BE7D").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Added).HasColumnName(@"added").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>