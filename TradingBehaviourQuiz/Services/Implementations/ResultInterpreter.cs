

using TradingBehaviourQuiz.Services.Interfaces;

namespace TradingBehaviourQuiz.Services.Implementations

//IResultInterpreter
{
    public class ResultInterpreter : IResultInterpreter
    {
        private readonly BehaviorProfileService _profileService;

        public ResultInterpreter()
        {
            _profileService = new BehaviorProfileService();
        }

        public void InterpretResults(Dictionary<string, int> categoryScores)
        {
            var profiles = _profileService.LoadProfiles();
            var dominant = categoryScores.OrderByDescending(k => k.Value).First().Key;

            var profile = dominant switch
            {
                "Impulsive" => profiles.Impulsive,
                "Disciplined" => profiles.Disciplined,
                "Reactive" => profiles.Reactive,
                "Emotional" => profiles.Emotional,
                _ => throw new ArgumentException("Unknown dominant behavior")
            };

            Console.WriteLine($"\n🧠 Dominant Behavior: {dominant}\n");
            Console.WriteLine(profile.Description);
            Console.WriteLine("\nSteps to Improve:");
            foreach (var step in profile.Steps)
            {
                Console.WriteLine($"- {step}");
            }
            Console.WriteLine("\nNext Steps:");
            foreach (var nextStep in profile.NextSteps)
            {
                Console.WriteLine($"- {nextStep}");
            }
        }
    }

}
