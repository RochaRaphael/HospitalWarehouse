using HospitalWarehouse.Data.Mapping;
using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWarehouse.DataContext
{
    public class HospitalDataContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<ConsumedProducts> ConsumedProducts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sector> Sector { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=HospitalWarehouse;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ConsumedProductsMap());
            modelBuilder.ApplyConfiguration(new ProductsMap());
            modelBuilder.ApplyConfiguration(new SectorMap());
        }

    }
}