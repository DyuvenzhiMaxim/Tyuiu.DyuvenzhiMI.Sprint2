﻿
using Tyuiu.DyuvenzhiMI.Sprint2.Task5.V4.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCardSuit()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Пики", ds.FindCardSuit(1));
            Assert.AreEqual("Трефы", ds.FindCardSuit(2));
            Assert.AreEqual("Бубны", ds.FindCardSuit(3));
            Assert.AreEqual("Червы", ds.FindCardSuit(4));

            Assert.ThrowsException<ArgumentException>(() => 
            {
                ds.FindCardSuit(0);
            });
            Assert.ThrowsException<ArgumentException>(() => 
            {
                ds.FindCardSuit(5);
            });
        }
    }
}
