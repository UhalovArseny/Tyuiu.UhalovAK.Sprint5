
namespace Tyuiu.UhalovAK.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekcedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}