using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC6MoodAnalyzer;

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
            UC6MoodAnalyzer.MoodAnalyser mood = new UC6MoodAnalyzer.MoodAnalyser("Today I am happy mood");

            actualoutput = mood.AnalyseMood();


            Assert.AreEqual(expectedoutput, actualoutput);

        }
        /// <summary>
        /// Tests the methodsad mood.
        /// </summary>
        [TestMethod]
        public void TestMethodsadMood()
        {
            string expectedoutput = "sad";
            string actualoutput;
            UC6MoodAnalyzer.MoodAnalyser mood = new UC6MoodAnalyzer.MoodAnalyser("Today I am sad mood");

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
                UC6MoodAnalyzer.MoodAnalyser mood = new UC6MoodAnalyzer.MoodAnalyser(msg);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException ce)
            {

                Assert.AreEqual(expectedoutput, ce.Message);
            }
        }
        /// <summary>
        /// Tests the method empty MSG.
        /// </summary>
        [TestMethod]

        public void TestMethodEmptyMsg()
        {
            string expected = "Mood should not be empty";

            try
            {


                UC6MoodAnalyzer.MoodAnalyser mood = new UC6MoodAnalyzer.MoodAnalyser(string.Empty);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException ce)
            {
                Assert.AreEqual(expected, ce.Message);

            }
        }
        /// <summary>
        /// Reflections the return default constructor.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void Reflection_Return_Default_Constructor()
        {
            MoodAnalyser expected = new MoodAnalyser();


            MoodAnalyserFactory factory = new MoodAnalyserFactory();
            object obj = factory.CreateMoodAnalyse("UC6MoodAnalyzer.MoodAnalyser", "MoodAnalyser");

            expected.Equals(obj);



        }
        //Neagtive Case
        [TestMethod]
        public void Reflection_Return_No_Class_Found()
        {
            string expected = "Class not found";
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyse("UC6MoodAnalyzer.MoodAnaly", "MoodAnaly");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreNotEqual(expected, obj);
            }






        }
        /// <summary>
        /// Reflections the return default constructor no constructor found.
        /// </summary>
        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyse("UC6MoodAnalyzer.MoodAnalyser", "MoodAnaly");

            }
            catch (MoodAnalysisException actual)
            {

                Assert.AreNotEqual(expected, actual.Message);
            }
        }

        /// <summary>
        /// Using Reflection-UC5-Parameterized Constructor
        /// </summary>

        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.CreateMoodAnalyserParameterizedObject("UC6MoodAnalyzer.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (MoodAnalysisException ex)
            {
                throw new System.Exception(ex.Message);
            }
            actual.Equals(expected);
        }
        //Invalid case
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.CreateMoodAnalyserParameterizedObject("UC6MoodAnalyzer.MoodAna", "MoodAnalyser", message);

            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreNotEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// Reflections the return method.
        /// </summary>
        [TestMethod]
        public void Reflection_Return_Method()
        {
            string expected = "happy";
            MoodAnalyserFactory factory = new MoodAnalyserFactory();
            string actual = factory.InvokeAnalyserMethod("happy", "AnalyseMood");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Reflection_Return_Invalid_Method()
        {
            string expected = "Method not found";
            try
            {

                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                string actual = factory.InvokeAnalyserMethod("happy", "MoodAnalyse");
            }
            catch (MoodAnalysisException ex)
            {

                Assert.AreEqual(expected, ex.Message);
            }


        }
    }
}
