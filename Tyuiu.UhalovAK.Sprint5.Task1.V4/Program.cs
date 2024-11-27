
using Tyuiu.UhalovAK.Sprint5.Task1.V4.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Массивы                                                   *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #23                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + startValue+ ";"+stopValue);








            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue,stopValue);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
