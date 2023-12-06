using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task1.V28.Lib;

namespace Tyuiu.TitkovAA.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(-0.186,Math.Round(dt.GetSumSeries(0.5,1,18),3));
        }
    }
}
