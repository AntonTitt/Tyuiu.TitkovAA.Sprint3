using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task5.V21.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(3.667, dt.GetSumSumSeries(2, 1, 3, 1, 10));
        }
    }
}
