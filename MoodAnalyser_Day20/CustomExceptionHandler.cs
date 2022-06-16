using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Day20
{
    public class CustomExceptionHandler
    {
        public void shownullException(string message)
        {
                throw (new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null"));  
        }

        public void showEmptyException(string message)
        {
            throw (new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Empty"));
        }
    }
}