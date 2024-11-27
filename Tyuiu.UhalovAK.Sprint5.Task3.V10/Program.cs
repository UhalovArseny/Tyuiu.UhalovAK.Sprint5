using Tyuiu.UhalovAK.Sprint5.Task3.V10.Lib;
namespace Tyuiu.UhalovAK.Sprint5.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #10                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x = 4;
            Console.WriteLine("x = " + x);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}