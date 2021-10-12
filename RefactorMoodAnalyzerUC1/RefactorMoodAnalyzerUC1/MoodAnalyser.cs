using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorMoodAnalyzerUC1
{
   public class MoodAnalyser
    {
        private string msg;
        public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }
      
            public string AnalyseMood()
            {
               
                if (msg.ToLower().Contains("any"))
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
