using System;

namespace UC2MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MoodAnalyzer");
            MoodAnalyser mood = new MoodAnalyser(" ");
            string res = mood.AnalyseMood();
            Console.WriteLine(res);
        }
    }
}
