// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // EventProcessor
    public class EventProcessorConfiguration : IEntityTypeConfiguration<EventProcessor>
    {
        public void Configure(EntityTypeBuilder<EventProcessor> builder)
        {
            builder.ToTable("EventProcessor", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_EventProcessor").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar(200)").IsRequired().IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(512)").IsRequired(false).IsUnicode(false).HasMaxLength(512);
            builder.Property(x => x.EndpointAddress).HasColumnName(@"EndpointAddress").HasColumnType("varchar(512)").IsRequired(false).IsUnicode(false).HasMaxLength(512);
            builder.Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
