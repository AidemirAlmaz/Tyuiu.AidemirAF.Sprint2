using Tyuiu.AidemirAF.Sprint2.Task6.V13.Lib;

namespace Tyuiu.AidemirAF.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1.2.2000", ds.FindDateOfNextDay(31, 1, 2000));
            Assert.AreEqual("1.1.2001", ds.FindDateOfNextDay(31, 12, 2000));
            Assert.AreEqual("1.3.2000", ds.FindDateOfNextDay(29, 2, 2000));
            Assert.AreEqual("1.5.2000", ds.FindDateOfNextDay(30, 4, 2000));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, -1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2025, 13, 32);
            });
        }
    }
}