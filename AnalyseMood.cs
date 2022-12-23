using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser1
{
    public class AnalyseMood
    {
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerTutorial.UseCases.UC6.MoodAnalyse");
                object moodAnalyseObject = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstrucor("MoodAnalyzerTutorial.UseCases.UC6.MoodAnalyse",
                    "MoodAnalyse", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullException n)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }
    }
}
