
using Tyuiu.DyuvenzhiMI.Sprint2.Task6.V7.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MonthName()
        {
            DataService ds = new DataService();
            int n = 2;
            Assert.AreEqual("март", ds.FindMonthName(1990, 1+n));
            Assert.AreEqual("июнь", ds.FindMonthName(1990, 30));
        }
    }
}
