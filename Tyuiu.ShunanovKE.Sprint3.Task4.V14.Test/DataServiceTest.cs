using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task4.V14.Lib;
namespace Tyuiu.ShunanovKE.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -2, stop = 2;
            double res = ds.Calculate(start, stop);
            double wait = -0.184;

            Assert.AreEqual(res, wait);
        }
    }
}
