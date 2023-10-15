using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint2.Task4.V13.Lib;

namespace Tyuiu.SorokinMA.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            double x = 4, y = 12;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            double wait = 123.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            double x = 1, y = 12;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            double wait = 0.096;
            Assert.AreEqual(wait, res);
        }
    }
}
