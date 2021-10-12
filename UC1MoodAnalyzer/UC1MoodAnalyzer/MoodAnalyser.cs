using System;
using System.Collections.Generic;
using System.Text;

namespace UC1MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else if (msg.ToLower().Contains("any"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
