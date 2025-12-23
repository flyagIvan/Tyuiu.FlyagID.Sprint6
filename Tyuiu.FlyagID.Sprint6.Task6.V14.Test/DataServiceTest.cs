using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint6.Task6.V14.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_ReturnWordsWithZ()
        {
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile,
                "zebra apple pizza moon zero lazy dog");

            DataService ds = new DataService();

            string result = ds.CollectTextFromFile(tempFile);

            string expected = "zebra pizza zero lazy";
            Assert.AreEqual(expected, result);

            File.Delete(tempFile);
        }

        [TestMethod]
        public void CollectTextFromFile_FileNotExist_ReturnEmpty()
        {
            DataService ds = new DataService();

            string result = ds.CollectTextFromFile("not_exist.txt");

            Assert.AreEqual(string.Empty, result);
        }
    }
}
