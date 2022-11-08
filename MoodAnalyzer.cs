using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthmaticProblem
{
    public class MoodAnalyzer
    {
        public string AnalysedMood(string massege)
        {
            if(massege.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
