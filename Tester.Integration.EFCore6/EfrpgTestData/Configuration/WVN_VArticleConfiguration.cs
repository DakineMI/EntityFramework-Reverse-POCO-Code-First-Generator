// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // v_Articles
    public class WVN_VArticleConfiguration : IEntityTypeConfiguration<WVN_VArticle>
    {
        public void Configure(EntityTypeBuilder<WVN_VArticle> builder)
        {
            builder.ToView("v_Articles", "WVN");
            builder.HasNoKey();

            builder.Property(x => x.PkArticle).HasColumnName(@"PK_Article").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.FkFactory).HasColumnName(@"FK_Factory").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.FkArticleLevel).HasColumnName(@"FK_ArticleLevel").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.FkParentArticle).HasColumnName(@"FK_ParentArticle").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar(20)").IsRequired(false).HasMaxLength(20);
            builder.Property(x => x.FullCode).HasColumnName(@"FullCode").HasColumnType("nvarchar(100)").IsRequired(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>