// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.co.uk/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 15 DEC 2022
//
// The following connection settings were used to generate this file:
//     Connection String Name: "FredDbContext"
//     Connection String:      "Data Source=(local);Initial Catalog=Fred;Integrated Security=True"
//
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2037.2
//
// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V3Fred
{
    // RebelGalaxyShips
    public class RebelGalaxyShipConfiguration : IEntityTypeConfiguration<RebelGalaxyShip>
    {
        public void Configure(EntityTypeBuilder<RebelGalaxyShip> builder)
        {
            builder.ToTable("RebelGalaxyShips", "dbo");
            builder.HasKey(x => new { x.Broadsides, x.Turrets, x.Cost });

            builder.Property(x => x.ShipName).HasColumnName(@"ShipName").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Broadsides).HasColumnName(@"Broadsides").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Turrets).HasColumnName(@"Turrets").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Cost).HasColumnName(@"Cost").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
