using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task2.V3.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService dt = new DataService();
            Assert.AreEqual(1694, dt.GetSumSeries(4, 1, 15));


        }
    }
}
