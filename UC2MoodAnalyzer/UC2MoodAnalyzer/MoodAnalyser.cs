using System;
using System.Collections.Generic;
using System.Text;

namespace UC2MoodAnalyzer
{
    public class MoodAnalyser
    {

       
            string msg;
            public MoodAnalyser(string msg)
            {
                this.msg = msg;
            }

            public string AnalyseMood()
            {
                try
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
                catch (NullReferenceException)
                {
                    return "happy";

                }
            }
        
    }
}
