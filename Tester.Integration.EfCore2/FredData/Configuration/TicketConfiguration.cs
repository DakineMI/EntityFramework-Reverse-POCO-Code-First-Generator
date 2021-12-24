// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // Ticket
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Ticket").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.CreatedById).HasColumnName(@"CreatedById").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.ModifiedById).HasColumnName(@"ModifiedById").HasColumnType("bigint").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.CreatedBy).WithMany(b => b.Tickets_CreatedById).HasForeignKey(c => c.CreatedById).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Ticket_AppUser");
            builder.HasOne(a => a.ModifiedBy).WithMany(b => b.Tickets_ModifiedById).HasForeignKey(c => c.ModifiedById).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Ticket_AppUser1");
        }
    }

}
// </auto-generated>
