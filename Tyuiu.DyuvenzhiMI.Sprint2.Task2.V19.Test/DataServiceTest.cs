
using Tyuiu.DyuvenzhiMI.Sprint2.Task2.V19.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckBoolValid()
        {
            DataService ds = new DataService();
            int x = 10; int y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
