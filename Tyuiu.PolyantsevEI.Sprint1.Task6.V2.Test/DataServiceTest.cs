using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint1.Task6.V2.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, World";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
