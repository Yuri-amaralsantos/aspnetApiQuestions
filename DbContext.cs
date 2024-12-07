using Microsoft.EntityFrameworkCore;
using question_api.Model;

namespace question_api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSets for your entities
        public DbSet<Questoes> QuestoesAnonimas { get; set; } // Example entity
    }
}
