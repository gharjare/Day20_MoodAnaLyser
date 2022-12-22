using MoodAnalyser1;

namespace UnitTest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullMoodReturnHappy()
        {
            string actual = "Happy";
            MoodAnalyse analyse = new MoodAnalyse("I am in Happy Mood");

            Assert.AreEqual(actual, "Happy");
        }
    }
}