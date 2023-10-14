using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint2.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x =1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x,y);
            bool[] meow = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(meow, res);
        }
    }
}
