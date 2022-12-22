using MoodAnalyser1;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnHappy()
        {
            string actual = "Happy";

            MoodAnalyse analyse = new MoodAnalyse("I am in Happy Mood");

            Assert.AreEqual("Happy", actual);
        }
    }
}