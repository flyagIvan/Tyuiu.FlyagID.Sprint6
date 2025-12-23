using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint6.Task4.V4.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_ReturnCorrectLength()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
        }
    }
}
