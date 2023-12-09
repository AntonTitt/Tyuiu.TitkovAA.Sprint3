using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task6.V23.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(35, dt.GetSumTheDivisors(18, 28));
        }
    }
}
