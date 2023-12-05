using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task0.V21.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();

            Assert.AreEqual(-63.727, Math.Round(dt.GetSumSeries(1.5, 1, 13),3));
        }
    }
}
