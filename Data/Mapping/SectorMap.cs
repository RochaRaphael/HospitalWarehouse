using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class SectorMap : IEntityTypeConfiguration<Sector>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sector");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

            builder.Property(x => x.SectorName)
                .IsRequired()
                .HasColumnName("Sector Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(40);
        }
    }
}