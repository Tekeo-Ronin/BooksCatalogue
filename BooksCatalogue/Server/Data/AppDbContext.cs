using Microsoft.EntityFrameworkCore;
using BooksCatalogue.Shared.Models; // Замініть на правильний простір імен для ваших моделей

namespace BooksCatalogue.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } // Додайте DbSet для вашої моделі
    }
}
