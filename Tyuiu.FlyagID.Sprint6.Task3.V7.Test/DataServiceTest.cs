using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint6.Task3.V7.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSortByFourthColumn()
        {
            DataService ds = new DataService();
            int[,] result = ds.Calculate(null);

            Assert.AreEqual(-6, result[0, 3]);
            Assert.AreEqual(2, result[1, 3]);
            Assert.AreEqual(4, result[2, 3]);
            Assert.AreEqual(12, result[3, 3]);
            Assert.AreEqual(14, result[4, 3]);
        }
    }
}
