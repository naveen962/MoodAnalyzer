using System;

namespace UC3MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = " ";
            Console.WriteLine("Welcome To MoodAnalyzer");
            MoodAnalyser mood = new MoodAnalyser(msg);
            string res = mood.AnalyseMood();
            Console.WriteLine(res);
        }
    }
}
