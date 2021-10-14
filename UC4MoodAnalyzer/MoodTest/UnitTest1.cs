using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC4MoodAnalyzer;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethodAnyMood()
        {

            string expectedoutput = "happy";
            string actualoutput;
            UC4MoodAnalyzer.MoodAnalyser mood = new UC4MoodAnalyzer.MoodAnalyser("Today I am happy mood");

            actualoutput = mood.AnalyseMood();


            Assert.AreEqual(expectedoutput, actualoutput);

        }
        [TestMethod]
        public void TestMethodsadMood()
        {
            string expectedoutput = "sad";
            string actualoutput;
            UC4MoodAnalyzer.MoodAnalyser mood = new UC4MoodAnalyzer.MoodAnalyser("Today I am sad mood");

            actualoutput = mood.AnalyseMood();

            Assert.AreEqual(expectedoutput, actualoutput);

        }
        [TestMethod]
        [DataRow(null)]
        public void TestMethodNull(string msg)
        {
            string expectedoutput = "Mood should not be Null";

            try
            {
                UC4MoodAnalyzer.MoodAnalyser mood = new UC4MoodAnalyzer.MoodAnalyser(msg);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException ce)
            {

                Assert.AreEqual(expectedoutput, ce.Message);
            }
        }

        [TestMethod]

        public void TestMethodEmptyMsg()
        {
            string expected = "Mood should not be empty";

            try
            {


                UC4MoodAnalyzer.MoodAnalyser mood = new UC4MoodAnalyzer.MoodAnalyser(string.Empty);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException ce)
            {
                Assert.AreEqual(expected, ce.Message);

            }
        }
    }
}
