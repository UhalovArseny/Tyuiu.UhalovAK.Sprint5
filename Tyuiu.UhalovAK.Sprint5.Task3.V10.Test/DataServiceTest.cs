namespace Tyuiu.UhalovAK.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekcedExistsFile()
        {
            string path = @"C:\Users\akukh\AppData\Local\Temp\OutPutFileTask2.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}