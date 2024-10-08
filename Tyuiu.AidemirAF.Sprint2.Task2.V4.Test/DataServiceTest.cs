using Tyuiu.AidemirAF.Sprint2.Task2.V4.Lib;

namespace Tyuiu.AidemirAF.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}