using System;
using System.Collections.Generic;
using System.Text;

namespace UC3MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string msg;
        public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }
        public string AnalyseMood()
        {

            try
            {
                if (msg.Equals(string.Empty))
                {
                    throw (new CustomMoodException(CustomMoodException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty"));
                }

                else if (msg.ToLower().Contains("any") || msg.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                throw (new CustomMoodException(CustomMoodException.ExceptionType.NULL_MESSAGE, "Mood should not be Null"));

            }
        }
    }
    
}
