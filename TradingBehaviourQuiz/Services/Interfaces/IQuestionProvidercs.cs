
using TradingBehaviourQuiz.Models;

namespace TradingBehaviourQuiz.Services.Interfaces
{
    public interface IQuestionProvider
    {
        List<Question> GetQuestions();
    }
}
