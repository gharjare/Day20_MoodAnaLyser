using MoodAnalyser1;

namespace TestCase7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsingParameterizedConstructor()
        {
            MoodAnalyse analyse = new MoodAnalyse("Happy");
            object expected = new MoodAnalyse("Happy");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstrucor("MoodAnalyser1.MoodAnalyse", "MoodAnalyse", "Happy");
            expected.Equals(obj);
        }
    }
}