namespace MoodAnalyser_Day20
{
    /// <summary>
    /// In this program we are going to Analyse the moods of the user like happy or sad.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program of Mood Analyser");
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            Console.WriteLine(moodAnalyser.AnalyseMood("I'm in any mood".ToLower()));


        }
    }
}