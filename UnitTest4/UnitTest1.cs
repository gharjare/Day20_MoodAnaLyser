using MoodAnalyser1;

namespace UnitTest4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullMood()
        {
            string actual = "Null";
            MoodAnalyse analyse = new MoodAnalyse("The mood is null");
            Assert.AreEqual(actual,"Null");
        }
    }
}