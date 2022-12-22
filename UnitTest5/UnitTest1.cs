using MoodAnalyser1;

namespace UnitTest5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyMood()
        {
            string actual = "Empty";
            MoodAnalyse analyse = new MoodAnalyse("The mood is empty");
            Assert.AreEqual(actual, "Empty");
        }
    }
}