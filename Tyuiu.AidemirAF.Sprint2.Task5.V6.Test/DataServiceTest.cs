using Tyuiu.AidemirAF.Sprint2.Task5.V6.Lib;

namespace Tyuiu.AidemirAF.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Шестерка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Семерка пик", ds.FindCardNameAndValue(1, 7));
            Assert.AreEqual("Восьмерка пик", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("Девятка пик", ds.FindCardNameAndValue(1, 9));
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("Валет пик", ds.FindCardNameAndValue(1, 11));
            Assert.AreEqual("дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("Король пик", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(1, 14));

            Assert.AreEqual("Шестерка трефы", ds.FindCardNameAndValue(2, 6));
            Assert.AreEqual("Семерка трефы", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("Восьмерка трефы", ds.FindCardNameAndValue(2, 8));
            Assert.AreEqual("Девятка трефы", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("Десятка трефы", ds.FindCardNameAndValue(2, 10));
            Assert.AreEqual("Валет трефы", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("Дама трефы", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("Король трефы", ds.FindCardNameAndValue(2, 13));
            Assert.AreEqual("Туз трефы", ds.FindCardNameAndValue(2, 14));

            Assert.AreEqual("Шестерка бубны", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("Семерка бубны", ds.FindCardNameAndValue(3, 7));
            Assert.AreEqual("Восьмерка бубны", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("Девятка бубны", ds.FindCardNameAndValue(3, 9));
            Assert.AreEqual("Десятка бубны", ds.FindCardNameAndValue(3, 10));
            Assert.AreEqual("Валет бубны", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("Дама бубны", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("Король бубны", ds.FindCardNameAndValue(3, 13));
            Assert.AreEqual("Туз бубны", ds.FindCardNameAndValue(3, 14));

            Assert.AreEqual("Шестерка червы", ds.FindCardNameAndValue(4, 6));
            Assert.AreEqual("Семерка червы", ds.FindCardNameAndValue(4, 7));
            Assert.AreEqual("Восьмерка червы", ds.FindCardNameAndValue(4, 8));
            Assert.AreEqual("Девятка червы", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("Десятка червы", ds.FindCardNameAndValue(4, 10));
            Assert.AreEqual("Валет червы", ds.FindCardNameAndValue(4, 11));
            Assert.AreEqual("Дама червы", ds.FindCardNameAndValue(4, 12));
            Assert.AreEqual("Король червы", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("Туз червы", ds.FindCardNameAndValue(4, 14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(-1, 5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 15);
            });
        }
    }
}