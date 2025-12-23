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

            int[,] matrix =
            {
                { 31, 25, -18, 12,   9 },
                {  6, 34,  -2,  2, -18 },
                { -5,  4,  27,  4,  -1 },
                {  4, 15,  34, -6, -10 },
                {  0,  8,   5, 14, -17 }
            };

            int[,] result = ds.Calculate(matrix);

            Assert.AreEqual(-6, result[0, 3]);
            Assert.AreEqual(2, result[1, 3]);
            Assert.AreEqual(4, result[2, 3]);
            Assert.AreEqual(12, result[3, 3]);
            Assert.AreEqual(14, result[4, 3]);
        }
    }
}
