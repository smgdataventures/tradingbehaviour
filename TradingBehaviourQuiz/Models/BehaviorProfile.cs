using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingBehaviourQuiz.Models
{
    public class BehaviorProfile
    {
        public string Description { get; set; }
        public List<string> Steps { get; set; }
        public List<string> NextSteps { get; set; }
    }
}
