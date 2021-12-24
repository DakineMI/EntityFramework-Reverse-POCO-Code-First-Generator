// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // PersonPosts
    public class PersonPostConfiguration : IEntityTypeConfiguration<PersonPost>
    {
        public void Configure(EntityTypeBuilder<PersonPost> builder)
        {
            builder.ToTable("PersonPosts", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__PersonPo__3214EC0714F40FA4").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Title).HasColumnName(@"Title").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Body).HasColumnName(@"Body").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Person_CreatedBy).WithMany(b => b.PersonPosts_CreatedBy).HasForeignKey(c => c.CreatedBy).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PersonPosts_CreatedBy");
            builder.HasOne(a => a.Person_UpdatedBy).WithMany(b => b.PersonPosts_UpdatedBy).HasForeignKey(c => c.UpdatedBy).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PersonPosts_UpdatedBy");
        }
    }

}
// </auto-generated>
