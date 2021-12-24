// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // hierarchy_test
    public class HierarchyTestConfiguration : IEntityTypeConfiguration<HierarchyTest>
    {
        public void Configure(EntityTypeBuilder<HierarchyTest> builder)
        {
            builder.ToTable("hierarchy_test", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__hierarch__3214EC27A00D9B63").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.Hid).HasColumnName(@"hid").HasColumnType("hierarchyid").IsRequired();
        }
    }

}
// </auto-generated>
