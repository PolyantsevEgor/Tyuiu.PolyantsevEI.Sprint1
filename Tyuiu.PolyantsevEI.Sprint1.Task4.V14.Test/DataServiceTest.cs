using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint1.Task4.V14.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 7.59;
            double y = 4.81;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.006, res);

        }
    }
}
