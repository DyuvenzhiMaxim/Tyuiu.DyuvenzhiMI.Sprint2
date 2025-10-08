
using Tyuiu.DyuvenzhiMI.Sprint2.Task3.V13.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1() {
            DataService ds = new DataService();
            double x = 2;
            double y = ds.Calculate(x);
            Assert.AreEqual(-7, y);
        }

        [TestMethod]
        public void ValidCondition2() {
            DataService ds = new DataService();
            double x = 0;
            double y = ds.Calculate(x);
            Assert.AreEqual(0.75, y);
        }

        [TestMethod]
        public void ValidCondition3() { 
            DataService ds = new DataService();
            double x = 1;
            double y = ds.Calculate(x);
            Assert.AreEqual(11, y);
        }

        [TestMethod]
        public void ValidCondition4() {
            DataService ds = new DataService();
            double x = -100;
            double y = ds.Calculate(x);
            Assert.AreEqual(-1099.99, y);
        }
    }
}   
