using Microsoft.EntityFrameworkCore;
using question_api.Models;

namespace question_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSets for your entities
        public DbSet<Item> Items { get; set; } // Example entity
    }
}
