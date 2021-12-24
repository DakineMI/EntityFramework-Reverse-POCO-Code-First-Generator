// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // EnumWithDefaultValue
    public class EnumWithDefaultValueConfiguration : IEntityTypeConfiguration<EnumWithDefaultValue>
    {
        public void Configure(EntityTypeBuilder<EnumWithDefaultValue> builder)
        {
            builder.ToTable("EnumWithDefaultValue", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__EnumWith__3214EC07A2120E43").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.SomeEnum).HasColumnName(@"SomeEnum").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
