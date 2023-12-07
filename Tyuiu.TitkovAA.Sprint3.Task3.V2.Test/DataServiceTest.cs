using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task3.V2.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(3, dt.GetMaxCharCount("asdzzz vfvfzz v gthvz", 'z'));
        }
    }
}
