using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

            builder.Property(x => x.CategoryName)
                .IsRequired()
                .HasColumnName("Category Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(40);
        }
    }
}