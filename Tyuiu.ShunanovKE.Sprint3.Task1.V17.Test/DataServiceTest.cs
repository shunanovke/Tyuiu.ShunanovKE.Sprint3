using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task1.V17.Lib;

namespace Tyuiu.ShunanovKE.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x = 1, start = 1, end = 3;
            double res = ds.GetMultiplySeries(x, start, end);
            double wait = 2572.522;

            Assert.AreEqual(res, wait);
        }
    }
}
