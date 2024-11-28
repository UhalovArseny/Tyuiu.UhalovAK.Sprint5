using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;
namespace Tyuiu.UhalovAK.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string content = File.ReadAllText(path);
                content = content.Replace('.', ',');
                string[] numberStrings = content.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                double[] numbers = Array.ConvertAll(numberStrings, double.Parse);

                double max = 0;
                for (int i = 0; i < numbers.Length;  i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;

            }

        }
    }
}
