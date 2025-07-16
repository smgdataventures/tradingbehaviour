

using TradingBehaviourQuiz.Services.Interfaces;

namespace TradingBehaviourQuiz.Services.Implementations
{
    public class ResultInterpreter : IResultInterpreter
    {
        public void InterpretResults(Dictionary<string, int> categoryScores)
        {
            Console.WriteLine("\n--- Behavior Profile ---");
            foreach (var kvp in categoryScores.OrderByDescending(k => k.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            var dominant = categoryScores.OrderByDescending(k => k.Value).First().Key;
            Console.WriteLine($"\\n🧠 Dominant Behavior: {dominant}");

            switch (dominant)
            {
                case "Impulsive":
                    Console.WriteLine("⚠️ You may benefit from journaling and pre-trade checklists.");
                    break;
                case "Disciplined":
                    Console.WriteLine("✅ You have a strong base. Focus on consistency and position sizing.");
                    break;
                case "Reactive":
                    Console.WriteLine("🔁 Reduce noise—focus on your strategy, not news triggers.");
                    break;
                case "Emotional":
                    Console.WriteLine("😓 Watch for revenge trades. Practice patience and detachment.");
                    break;
            }
        }
    }
}
