using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;
namespace Tyuiu.UhalovAK.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(path); }

            double res;
            string strRes;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round((((Math.Cos(x)) / ( 1 + x)) - Math.Cos(x)*1.3+ (3*x)),2);
                strRes = Convert.ToString(res);

                if (x == -1)
                {
                    
                    res = 0;
                    strRes = Convert.ToString(res);
                }
               

                if (x != stopValue)
                {
                    File.AppendAllText(path, strRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strRes);
                }
            }
            return path;
        }
    }
}
