using System;

namespace UC1MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MoodAnalyzer");
            MoodAnalyser mood = new MoodAnalyser();
           string res=mood.AnalyseMood("I am happy");
            Console.WriteLine(res);
        }
    }
}
