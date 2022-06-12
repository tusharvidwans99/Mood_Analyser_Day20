using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Day20
{
    public class MoodAnalyser
    {

        public string AnalyseMood(string message)
        {
            if (message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

    }
}
