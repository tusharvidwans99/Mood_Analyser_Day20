using MoodAnalyser_Day20;

namespace TestMoodAnalyser
{
    [TestClass]
    public class MoodAnaylyser_Test
    {
        [TestMethod]
        public void AnalyseMood_SadTest()
        {

            //Arrange
            string message = "I am in Sad Mood.";
            string expected_Output = "Sad";
            string actual_Output;

            MoodAnalyser moodAnaylyser = new MoodAnalyser(message.ToLower());

            //Act

            actual_Output = moodAnaylyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected_Output, actual_Output);

        }

        [TestMethod]
        public void AnalyseMood_HappyTest()
        {

            //Arrange
            string message = "I am in Any Mood.";
            string expected_Output = "Happy";
            string actual_Output;

            MoodAnalyser moodAnaylyser = new MoodAnalyser(message.ToLower());

            //Act

            actual_Output = moodAnaylyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected_Output, actual_Output);

        }


        [TestMethod]
        public void AnalyseMood_NullTest()
        {

            //Arrange
            string message = null;
            string expected_Output = "Mood should not be null";
            string actual_Output;

            MoodAnalyser moodAnaylyser = new MoodAnalyser(message);

            //Act

            actual_Output = moodAnaylyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected_Output, actual_Output);

        }


        [TestMethod]
        public void AnalyseMood_EmptyTest()
        {

            //Arrange
            string message = "";
            string expected_Output = "Mood should not be Empty";
            string actual_Output;

            MoodAnalyser moodAnaylyser = new MoodAnalyser(message);

            //Act

            actual_Output = moodAnaylyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected_Output, actual_Output);

        }

        [TestMethod]
        public void ClassNameReturnSameObject()
        {
            //Arrange
            string message = null;
            object expected = new MoodAnalyser(message);
            object actual;

            //Act
            actual = MoodAnalyzerFactory.CreateMoodAnalysis("MoodAnalyser_Day20.MoodAnalyser","MoodAnalyser");

            //Assert
            expected.Equals(actual);
        }


       
       

    }   
}