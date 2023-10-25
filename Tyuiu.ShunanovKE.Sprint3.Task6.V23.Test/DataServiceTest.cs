using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task6.V23.Lib;

namespace Tyuiu.ShunanovKE.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 13, end = 15;
            int res = ds.GetSumTheDivisors(start, end);
            int wait = 7;
            Assert.AreEqual(res, wait);
        }
    }
}
