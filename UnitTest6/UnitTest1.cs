using MoodAnalyser1;
using System.Xml.Linq;

namespace UnitTest6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnMoodAnalyseObject()
        {
            MoodAnalyse analyse = new MoodAnalyse("should return mood analysis object");
            string input = null;
            object expected = new MoodAnalyse(input);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser1.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }
            
        
    }
}