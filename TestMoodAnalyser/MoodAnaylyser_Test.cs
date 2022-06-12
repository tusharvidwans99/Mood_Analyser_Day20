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

            MoodAnalyser moodAnaylyser = new MoodAnalyser();

            //Act

            actual_Output = moodAnaylyser.AnalyseMood(message.ToLower());

            //Assert
            Assert.AreEqual(expected_Output, actual_Output);

        }
    }
}