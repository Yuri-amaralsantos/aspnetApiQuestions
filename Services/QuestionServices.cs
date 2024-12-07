using Microsoft.EntityFrameworkCore;
using question_api.Interfaces;
using question_api.Model;

namespace question_api.Services
{
    public class QuestionServices : IQuestionServices
    {
        private readonly AppDbContext _context;

        public QuestionServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetRandomQuestionsAsync()
        {
            var questions = _context.QuestoesAnonimas
                .AsEnumerable() // Carrega os dados para a memória
                .OrderBy(q => Guid.NewGuid()) // Ordena aleatoriamente no lado do cliente
                .Take(2)  
                .ToList();

            return questions;
        }

    }
}