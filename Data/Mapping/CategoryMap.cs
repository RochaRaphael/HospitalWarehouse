using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
        }
    }
}