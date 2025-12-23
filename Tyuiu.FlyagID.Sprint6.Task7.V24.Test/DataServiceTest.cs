using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint6.Task7.V24.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceEvenElementsInSecondRow()
        {
            string temp = Path.GetTempFileName();

            File.WriteAllText(temp,
                "3;4;7;9;10\n" +
                "2;6;5;8;11\n" +
                "1;12;14;3;5\n");

            DataService ds = new DataService();
            int[,] result = ds.GetMatrix(temp);

            Assert.AreEqual(1, result[1, 0]);
            Assert.AreEqual(1, result[1, 1]);
            Assert.AreEqual(5, result[1, 2]);
            Assert.AreEqual(1, result[1, 3]);
            Assert.AreEqual(11, result[1, 4]);

            File.Delete(temp);
        }
    }
}
