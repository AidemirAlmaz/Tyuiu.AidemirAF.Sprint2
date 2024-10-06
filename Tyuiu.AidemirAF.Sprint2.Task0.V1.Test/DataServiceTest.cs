using Tyuiu.AidemirAF.Sprint2.Task0.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}