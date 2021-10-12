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

            UC1MoodAnalyzer.MoodAnalyser mood = new UC1MoodAnalyzer.MoodAnalyser();
            actual = mood.AnalyseMood("I am in sad mood");

            Assert.AreEqual(expect, actual);

        }
        [TestMethod]
        public void TestMethodAnalyzeMoodhappy()
        {
            string expect = "happy";
            string actual;

            UC1MoodAnalyzer.MoodAnalyser mood = new UC1MoodAnalyzer.MoodAnalyser();
            actual = mood.AnalyseMood("I am in happy mood");

            Assert.AreEqual(expect, actual);

        }
    }
}
