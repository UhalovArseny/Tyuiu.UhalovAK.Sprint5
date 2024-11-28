using Tyuiu.UhalovAK.Sprint5.Task7.V2.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #2                                                                *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Файл: {ds.LoadDataAndSave(path)} ");
            Console.WriteLine($"* Создан!                                                       *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();
        }
    }
}