using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint1.Task3.V8.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500;
            double timeDays = 30;
            double percent = 20;
            var res = ds.IncomeAmount(startAmount, timeDays, percent);
            Assert.AreEqual(41.10, res);
        }
    }
}
