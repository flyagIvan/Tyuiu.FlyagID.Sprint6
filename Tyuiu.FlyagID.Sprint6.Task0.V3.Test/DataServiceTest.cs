using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint6.Task0.V3.Lib;
using System;

namespace Tyuiu.FlyagID.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int x = 3;
            double result = ds.Calculate(x);
            double expected = Math.Round((4 * Math.Pow(3, 3)) / (Math.Pow(3, 3) - 1), 3);

            Assert.AreEqual(expected, result);
        }
    }
}
