using Tyuiu.UhalovAK.Sprint5.Task6.V25.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #25                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt ";
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
