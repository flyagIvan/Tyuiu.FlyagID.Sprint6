using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint6.Task2.V20.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] res = ds.GetMassFunction(start, stop);

            Assert.AreEqual(11, res.Length);

            int index = (int)(-1.2 - start);
            if (index >= 0 && index < res.Length)
            {
                Assert.AreEqual(0, res[index]);
            }
        }
    }
}
