
using Tyuiu.DyuvenzhiMI.Sprint2.Task7.V7.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void DotInShadedArea()
        {
            double x = -1; double y = 1;
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
