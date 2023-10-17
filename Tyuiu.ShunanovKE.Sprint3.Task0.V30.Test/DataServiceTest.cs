using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task0.V30.Lib;


namespace Tyuiu.ShunanovKE.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int start = 2, end = 4;
            double res = ds.GetMultiplySeries(start, end);
            double wait = 0.135;

            Assert.AreEqual(res, wait);
        }
    }
}
