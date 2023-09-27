using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 219;
            DataService ds = new DataService();
            int n = ds.Calculate(k);
            Assert.AreEqual(2, n);
        }
    }
}
