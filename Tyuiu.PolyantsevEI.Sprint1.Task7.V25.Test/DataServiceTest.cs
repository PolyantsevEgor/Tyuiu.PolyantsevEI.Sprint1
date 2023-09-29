using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint1.Task7.V25.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double wait = 19.437;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
