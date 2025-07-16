
using TradingBehaviourQuiz.Services.Interfaces;

namespace TradingBehaviourQuiz.Services.Implementations
{
    public class QuizService : IQuizService
    {
        private readonly IQuestionProvider _questionProvider;
        private readonly IResultInterpreter _resultInterpreter;

        public QuizService()
        {
            _questionProvider = new QuestionProvider();
            _resultInterpreter = new ResultInterpreter();
        }

        public void RunQuiz()
        {
            var questions = _questionProvider.GetQuestions();
            var scores = new Dictionary<string, int>();

            foreach (var question in questions)
            {
                Console.WriteLine($"\\n{question.Text}");
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {question.Options[i].Text}");
                }

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > question.Options.Count)
                {
                    Console.WriteLine("Invalid input. Please choose a valid option number:");
                }

                string selectedCategory = question.Options[choice - 1].Category;
                if (!scores.ContainsKey(selectedCategory))
                    scores[selectedCategory] = 0;

                scores[selectedCategory]++;
            }

            _resultInterpreter.InterpretResults(scores);
        }
    }
}
