namespace MoodAnalyser_Day20
{
    /// <summary>
    /// In this program we are going to Analyse the moods of the user like happy or sad.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            string a = moodAnalyser.AnalyseMood();
            Console.WriteLine(a);
        }
    }
}