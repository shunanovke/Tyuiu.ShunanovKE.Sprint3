using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.Task3.V2.Lib;
namespace Tyuiu.ShunanovKE.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string str = "hhghg h gh ghhh hghh";
            char item = 'h';
            int res = ds.GetMaxCharCount(str, item), wait = 4;

            Assert.AreEqual(res, wait);
        }
    }
}
