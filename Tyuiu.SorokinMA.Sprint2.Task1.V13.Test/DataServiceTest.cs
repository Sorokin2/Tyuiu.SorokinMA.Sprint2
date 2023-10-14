using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint2.Task1.V13.Lib;

namespace Tyuiu.SorokinMA.Sprint2.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 145, b = 916, c = 164, d = 137;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] meow = new bool[6] { true, true, true, true, true, false };
            CollectionAssert.AreEqual(meow, res);
        }
    }
}
