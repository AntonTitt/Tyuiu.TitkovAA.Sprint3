using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Task7.V12.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double[] a = new double[3];
            a[0] = 0.52;
            a[1] = 4;
            a[2] = -0.75;
            CollectionAssert.AreEqual(a, dt.GetMassFunction(-1, 1));
        }
    }
}
