using Tyuiu.UhalovAK.Sprint5.Task5.V30.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #30                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V30.txt";
            Console.WriteLine("Данные находятся в файле:  " + path);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Ответ: " + res);

            Console.ReadKey();
        }
    }
}
