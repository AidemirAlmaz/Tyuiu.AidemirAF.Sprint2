using Tyuiu.AidemirAF.Sprint2.Task4.V30.Lib;

namespace Tyuiu.AidemirAF.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}