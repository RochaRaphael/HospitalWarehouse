using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class ConsumedProductsMap : IEntityTypeConfiguration<ConsumedProducts>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ConsumedProducts> builder)
        {
            builder.ToTable("Consumed Products");
        }
    }
}