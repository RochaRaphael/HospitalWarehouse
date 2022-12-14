using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.Data.Mapping
{
    public class ConsumedProductsMap : IEntityTypeConfiguration<ConsumedProducts>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ConsumedProducts> builder)
        {
            builder.ToTable("Consumed Products");

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
               .HasOne(x => x.SectorThatConsumed)
               .WithMany(x => x.ConsumedProducts)
               .HasConstraintName("FK_ConsumedProduct_Sector")
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(x => x.ProductCategory)
               .WithMany(x => x.ConsumedProducts)
               .HasConstraintName("FK_ConsumedProduct_Category")
               .OnDelete(DeleteBehavior.Cascade);


        }
    }
}