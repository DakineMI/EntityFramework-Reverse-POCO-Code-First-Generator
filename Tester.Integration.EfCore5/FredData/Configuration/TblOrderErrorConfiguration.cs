// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // tblOrderErrors
    public class TblOrderErrorConfiguration : IEntityTypeConfiguration<TblOrderError>
    {
        public void Configure(EntityTypeBuilder<TblOrderError> builder)
        {
            builder.ToTable("tblOrderErrors", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__tblOrder__3214EC27BAF60861").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Error).HasColumnName(@"error").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
