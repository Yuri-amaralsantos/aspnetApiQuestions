using question_api.Model;

namespace question_api.Interfaces
{
    public interface IQuestionServices
    {
        public Task<List<Question>> GetRandomQuestionsAsync();
    }
}