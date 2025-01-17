// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // UploadedFile
    public class OneEightSix_UploadedFileConfiguration : IEntityTypeConfiguration<OneEightSix_UploadedFile>
    {
        public void Configure(EntityTypeBuilder<OneEightSix_UploadedFile> builder)
        {
            builder.ToTable("UploadedFile", "OneEightSix");
            builder.HasKey(x => x.Id).HasName("PK_UploadedFile").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.FullPath).HasColumnName(@"FullPath").HasColumnType("nvarchar(max)").IsRequired();
        }
    }

}
// </auto-generated>
