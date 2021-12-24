// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;

namespace V5Fred
{
    // CMS_File
    public class CmsFileConfiguration : IEntityTypeConfiguration<CmsFile>
    {
        public void Configure(EntityTypeBuilder<CmsFile> builder)
        {
            builder.ToTable("CMS_File", "dbo");
            builder.HasKey(x => x.FileId).HasName("PK_CMS_Form").IsClustered();

            builder.Property(x => x.FileId).HasColumnName(@"FileId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.FileName).HasColumnName(@"FileName").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.FileDescription).HasColumnName(@"FileDescription").HasColumnType("varchar(500)").IsRequired().IsUnicode(false).HasMaxLength(500);
            builder.Property(x => x.FileIdentifier).HasColumnName(@"FileIdentifier").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.ValidStartDate).HasColumnName(@"ValidStartDate").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ValidEndDate).HasColumnName(@"ValidEndDate").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired();
            builder.HasMany<CmsTag>(t => t.CmsTags).WithMany(t => t.CmsFiles).UsingEntity<Dictionary<string, object>>("CMS_FileTag",
                    j => j.HasOne<CmsTag>().WithMany().HasForeignKey("TagId"),
                    j => j.HasOne<CmsFile>().WithMany().HasForeignKey("FileId"),
                    j => j.ToTable("CMS_FileTag", "dbo"));
        }
    }

}
// </auto-generated>
