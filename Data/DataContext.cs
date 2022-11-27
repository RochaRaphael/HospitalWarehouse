using HospitalWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataContext
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<ConsumedProducts> Posts { get; set; }
        public DbSet<Products> Users { get; set; }
        public DbSet<Sector> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=HospitalWarehouse;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");

    }
}