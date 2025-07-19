

using System.Text.Json;
using System.Text.Json.Serialization;
using TradingBehaviourQuiz.Models;

namespace TradingBehaviourQuiz.Services.Implementations
{
    public class BehaviorProfileService
    {
        private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "behavior_profiles.json");

        public BehaviorProfiles LoadProfiles()
        {
            string jsonString = File.ReadAllText(_filePath);

            BehaviorProfiles profiles = new BehaviorProfiles();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            
            return JsonSerializer.Deserialize<BehaviorProfiles>(jsonString, options);

        }
    }
}
