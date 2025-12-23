using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint6.Task1.V5.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, res.Length);
            Assert.AreEqual(Math.Round(Math.Sin(0) + Math.Cos(0) / 2, 2), res[5]);
        }
    }
}
