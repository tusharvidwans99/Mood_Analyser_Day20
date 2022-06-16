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
            string expected_Output = "Enterd Null Input";
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
            string expected_Output = "Empty Mood";
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
            actual = new MoodAnalyser(message);

            //Assert
            expected.Equals(actual);
        }
    }
}