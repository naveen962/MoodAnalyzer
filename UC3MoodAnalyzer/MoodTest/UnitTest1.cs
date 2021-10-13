using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC3MoodAnalyzer;


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
                UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser("Today I am happy mood");

                actualoutput = mood.AnalyseMood();
            

            Assert.AreEqual(expectedoutput, actualoutput);

        }
        [TestMethod]
        public void TestMethodsadMood()
        {
            string expectedoutput = "sad";
            string actualoutput;
            UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser("Today I am sad mood");

            actualoutput = mood.AnalyseMood();

            Assert.AreEqual(expectedoutput, actualoutput);

        }
        [TestMethod]
        [DataRow(null)]
        public void TestMethodNull(string msg)
        {
            string expectedoutput = "Mood should not be Null" ;
            
            try
            {
                UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser(msg);

                mood.AnalyseMood();
            }
            catch (CustomMoodException ce)
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


                UC3MoodAnalyzer.MoodAnalyser mood = new UC3MoodAnalyzer.MoodAnalyser(string.Empty);

                mood.AnalyseMood();
            }
            catch (CustomMoodException ce)
            {
                Assert.AreEqual(expected, ce.Message);

            }
        }
    }
}
