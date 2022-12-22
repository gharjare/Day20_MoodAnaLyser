using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser1
{
    public class HandleException
    {
        public string input;
        public string Analyse2()
        {
            try
            {
                if (input.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullException n)
            {
                return "Happyy";
            }
        }
    }
}
