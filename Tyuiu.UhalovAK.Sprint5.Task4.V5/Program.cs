using Tyuiu.UhalovAK.Sprint5.Task4.V5.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt ";
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