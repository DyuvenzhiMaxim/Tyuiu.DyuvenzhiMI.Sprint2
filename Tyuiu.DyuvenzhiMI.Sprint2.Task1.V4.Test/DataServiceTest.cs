
using Tyuiu.DyuvenzhiMI.Sprint2.Task1.V4.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void BoolValid()
        {
            int a = 175; int b = 176; int c = 414; int d = 414;
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[] {false, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
