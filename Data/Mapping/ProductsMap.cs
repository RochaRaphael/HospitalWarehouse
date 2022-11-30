using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class ProductsMap : IEntityTypeConfiguration<Products>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("INT");

            builder.Property(x => x.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasColumnType("MONEY");

            builder
               .HasOne(x => x.ProductCategory)
               .WithMany(x => x.Products)
               .HasConstraintName("FK_Product_Category")
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}