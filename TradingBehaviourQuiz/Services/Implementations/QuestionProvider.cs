using System.IO;
using Newtonsoft.Json;
using TradingBehaviourQuiz.Models;
using TradingBehaviourQuiz.Services.Interfaces;

namespace TradingBehaviourQuiz.Services.Implementations
{
    public class QuestionProvider : IQuestionProvider
    {
        private readonly string _filePath;

        public QuestionProvider()
        {
            _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "questions.json");
        }

        public List<Question> GetQuestions()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException($"Questions file not found: {_filePath}");

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Question>>(json)
                   ?? new List<Question>();
        }
    }
}
