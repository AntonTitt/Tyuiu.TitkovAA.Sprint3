using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task4.V9.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();

            Assert.AreEqual(1, dt.Calculate(-5, 5));
        }
    }
}
