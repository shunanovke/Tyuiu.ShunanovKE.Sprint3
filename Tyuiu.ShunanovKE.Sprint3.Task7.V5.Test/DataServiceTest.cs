using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task7.V5.Lib;

namespace Tyuiu.ShunanovKE.Sprint3.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -2, end = 2;
            int len = end - start + 1;
            double[] wait = new double[len];
            wait[0] = 27.96;
            wait[1] = 15.48;
            wait[2] = 1;
            wait[3] = -13.06;
            wait[4] = -28.16;
            double[] res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
