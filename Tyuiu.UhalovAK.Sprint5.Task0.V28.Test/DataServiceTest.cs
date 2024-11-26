using System.Diagnostics;
using System.IO;
using Tyuiu.UhalovAK.Sprint5.Task0.V28.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekcedExistsFile()
        {
            string path = @"C:\Users\akukh\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}
