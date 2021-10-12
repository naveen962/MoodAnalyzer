using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAnalyzeMoodsad()
        { 
            string expect = "sad";
            string actual;
        
            RefactorMoodAnalyzerUC1.MoodAnalyser mood = new RefactorMoodAnalyzerUC1.MoodAnalyser("I am in sad mood");
            actual=mood.AnalyseMood();

            Assert.AreEqual(expect, actual);

        }
        [TestMethod]
        public void TestMethodAnalyzeMoodhappy()
        {
            string expect = "sad";
            string actual;

            RefactorMoodAnalyzerUC1.MoodAnalyser mood = new RefactorMoodAnalyzerUC1.MoodAnalyser("I am in happy mood");
            actual = mood.AnalyseMood();

            Assert.AreEqual(expect, actual);

        }
    }
}
