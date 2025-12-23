using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint6.Task5.V20.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ReturnEvenValues()
        {
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(
                @"C:\flyagIvan\Tyuiu.FlyagID.Sprint6\Sprint6Task5\InPutFileTask5V20.txt");

            Assert.IsTrue(res.Length > 0);

            foreach (double v in res)
                Assert.AreEqual(0, v % 2, 0.0001);
        }

      
    }
}
