using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class SectorMap : IEntityTypeConfiguration<Sector>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sector");
        }
    }
}