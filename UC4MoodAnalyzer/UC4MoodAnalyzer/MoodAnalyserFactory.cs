using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace UC4MoodAnalyzer
{
    class MoodAnalyserFactory
    {
        public object CreateMoodAnalyserObject(string className, string constructor)
        {
            string p = @"." + constructor + "$";
            Match result = Regex.Match(className, p);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (Exception ex)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_CONSTRUCTOR_FOUND, "Constructor not found");
            }
        }

    }

}
