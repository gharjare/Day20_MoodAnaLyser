using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser1.MoodAnalysisException;

namespace MoodAnalyser1
{
    public class MoodAnalyse
    {
        public string input;

        public MoodAnalyse(string input)
        {
            this.input = input;
        }

        public string Analyse()
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
        public string Analyse1()
        {
            if (input.Contains("Happy"))
            {
                return "Happy";
            }
            else
            {
                return "Sad";
            }
        }
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
            } catch (NullException n)
            {
                return "Happyy";
            }

        }
        public string Analysis3()
        {
            try
            {
                if(input.Contains("Sad"))
                {
                    return "sad";
                }else if(input.Contains("Happy"))
                {
                    return "Happy";
                }else if(input.Contains(" "))
                {
                    throw new MoodAnalysisException(NullMoodErrors.EMPTYMOOD, "Enter nothing !!");
                }
                else
                {
                    return "Happy";
                }
            }catch(Exception e)
            {
                throw new MoodAnalysisException(NullMoodErrors.NULLMOOD, "Enter something !!");
            }
        }

		
		
    }

}
