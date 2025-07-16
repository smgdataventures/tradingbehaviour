

using TradingBehaviourQuiz.Models;
using TradingBehaviourQuiz.Services.Interfaces;

namespace TradingBehaviourQuiz.Services.Implementations
{
    public class QuestionProvider : IQuestionProvider
    {
        public List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Text = "How do you usually take your first trade of the day?",
                    Options = new List<Option>
                    {
                        new Option { Text = "By checking key technical levels", Category = "Disciplined" },
                        new Option { Text = "Based on news or social media buzz", Category = "Reactive" },
                        new Option { Text = "Impulsively as the market opens", Category = "Impulsive" }
                    }
                },
                new Question
                {
                    Text = "What do you do after your first profitable trade?",
                    Options = new List<Option>
                    {
                        new Option { Text = "Wait for the next setup", Category = "Disciplined" },
                        new Option { Text = "Feel overconfident and increase position size", Category = "Impulsive" },
                        new Option { Text = "Take revenge trades after a small loss", Category = "Emotional" }
                    }
                },
                new Question
                {
                    Text = "How often do you emotionally react to news or market chatter?",
                    Options = new List<Option>
                    {
                        new Option { Text = "Ignore noise and stick to your plan", Category = "Disciplined" },
                        new Option { Text = "Act immediately when news breaks", Category = "Reactive" },
                        new Option { Text = "Wait for peer confirmation before acting", Category = "Reactive" }
                    }
                },
                new Question
                {
                    Text = "If you hold a losing trade, how do you typically behave?",
                    Options = new List<Option>
                    {
                        new Option { Text = "Accept the stop loss and move on", Category = "Disciplined" },
                        new Option { Text = "Let it run hoping it reverses", Category = "Emotional" },
                        new Option { Text = "Immediately close out to cut pain", Category = "Impulsive" }
                    }
                },
                new Question
                {
                    Text = "Which cognitive bias do you recognize most in yourself?",
                    Options = new List<Option>
                    {
                        new Option { Text = "Only seeking info that confirms my view", Category = "Reactive" },
                        new Option { Text = "Fixating on original entry price", Category = "Reactive" },
                        new Option { Text = "Panicking when others react emotionally", Category = "Reactive" }
                    }
                },
                new Question
                {
                    Text = "What drives your trading decisions most?",
                    Options = new List<Option>
                    {
                        new Option { Text = "Structured plan and support/resistance levels", Category = "Disciplined" },
                        new Option { Text = "Fear of missing out on big moves", Category = "Emotional" },
                        new Option { Text = "Following peers or expert advice", Category = "Reactive" }
                    }
                },
                new Question
                {
                    Text = "How often do you journal or reflect on your emotional state post-trade?",
                    Options = new List<Option>
                    {
                        new Option { Text = "Always, to track patterns and improve", Category = "Disciplined" },
                        new Option { Text = "Rarely—I react more than reflect", Category = "Emotional" },
                        new Option { Text = "Never—only profit/loss matters", Category = "Impulsive" }
                    }
                }            };
        }
    }
}
