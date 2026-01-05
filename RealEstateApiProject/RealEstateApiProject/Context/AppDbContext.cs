using Microsoft.EntityFrameworkCore;
using RealEstateApiProject.Models;

namespace RealEstateApiProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } // Bu, veritabanında Products tablosu oluşturur
    }
}