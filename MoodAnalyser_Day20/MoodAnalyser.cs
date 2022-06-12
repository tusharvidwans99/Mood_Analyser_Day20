using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Day20
{
    public class MoodAnalyser
    {
        public string message;


        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            NullException nullException = new NullException();

            try
            {
                if (message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                nullException.shownullException(message);
            }catch(MoodAnalysisException e)
            {
                Console.WriteLine(e.Message);
                return "Happy";
            }
            
        }

    }
}
