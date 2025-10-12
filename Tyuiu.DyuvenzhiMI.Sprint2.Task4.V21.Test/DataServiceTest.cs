
using Tyuiu.DyuvenzhiMI.Sprint2.Task4.V21.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            double x = 1; double y = 1;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.905, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            double x = 1; double y = 4;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            Assert.AreEqual(256, res);
        }
    }
}
