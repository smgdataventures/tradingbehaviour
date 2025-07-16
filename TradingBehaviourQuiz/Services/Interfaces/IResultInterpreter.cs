using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingBehaviourQuiz.Services.Interfaces
{
    public interface IResultInterpreter
    {
        void InterpretResults(Dictionary<string, int> categoryScores);
    }
}

