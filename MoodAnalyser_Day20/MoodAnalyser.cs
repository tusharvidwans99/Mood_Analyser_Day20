using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Day20
{
    public class MoodAnalyser
    {

        public MoodAnalyser() { }

        public string message;

        /// <summary>
        /// Parameterized Contructor.
        /// </summary>
        /// <param name="message"></param>

        
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            CustomExceptionHandler customExceptionhandler = new CustomExceptionHandler();

            try
            {
                if(message == null)
                {
                    customExceptionhandler.shownullException();
                }
                if(message == "")
                {
                    customExceptionhandler.showEmptyException();
                }
                if (message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }catch(MoodAnalysisCustomException e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
            
        }

    }
}
