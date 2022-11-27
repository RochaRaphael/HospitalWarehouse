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

    }
}