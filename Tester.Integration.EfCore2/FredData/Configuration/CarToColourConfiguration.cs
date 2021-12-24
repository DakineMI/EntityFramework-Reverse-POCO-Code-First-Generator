// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // CarToColour
    public class CarToColourConfiguration : IEntityTypeConfiguration<CarToColour>
    {
        public void Configure(EntityTypeBuilder<CarToColour> builder)
        {
            builder.ToTable("CarToColour", "dbo");
            builder.HasKey(x => new { x.CarId, x.ColourId }).HasName("PK__CarToCol__8C02E66BFA508402").ForSqlServerIsClustered();

            builder.Property(x => x.CarId).HasColumnName(@"CarId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ColourId).HasColumnName(@"ColourId").HasColumnType("int").IsRequired().ValueGeneratedNever();

            // Foreign keys
            builder.HasOne(a => a.Car).WithMany(b => b.CarToColours).HasForeignKey(c => c.CarId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CarToColour_CarId");
            builder.HasOne(a => a.Colour).WithMany(b => b.CarToColours).HasForeignKey(c => c.ColourId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CarToColour_ColourId");
        }
    }

}
// </auto-generated>
