using Microsoft.EntityFrameworkCore;
using question_api.Model;

namespace question_api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSets for your entities
        public DbSet<Question> QuestoesAnonimas { get; set; } // Example entity




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = Guid.NewGuid(),
                    Prompt = "Qual das seguintes opções é usada para gerenciar a memória no .NET?", // Alterado para Prompt
                    Option1 = "Garbage Collector",
                    Option2 = "Memory Allocator",
                    Option3 = "Memory Manager",
                    Option4 = "Heap Manager",
                    Option5 = "Stack Manager",
                    CorrectAnswer = 1
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Prompt = "Qual é a classe base para todas as classes no .NET?", // Alterado para Prompt
                    Option1 = "Object",
                    Option2 = "Base",
                    Option3 = "Core",
                    Option4 = "System",
                    Option5 = "Root",
                    CorrectAnswer = 1
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Prompt = "Qual palavra-chave é usada para definir um método que não retorna valor?", // Alterado para Prompt
                    Option1 = "null",
                    Option2 = "void",
                    Option3 = "empty",
                    Option4 = "none",
                    Option5 = "nil",
                    CorrectAnswer = 2
                }
            );

        }

    }
}
