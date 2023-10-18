using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task2.V25.Lib;

namespace Tyuiu.ShunanovKE.Sprint3.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int n = 5, start = 1, end = 3;
            double res = ds.GetSumSeries(n, start, end);
            double wait = 16.016;

            Assert.AreEqual(res, wait);
        }
    }
}
