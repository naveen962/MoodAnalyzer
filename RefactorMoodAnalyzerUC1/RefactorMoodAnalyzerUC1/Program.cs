using System;

namespace RefactorMoodAnalyzerUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MoodAnalyzer");
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
           string res= mood.AnalyseMood();
            Console.WriteLine(res);
           
        }
    }
}
