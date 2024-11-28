using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

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

                double maxPrime = double.MinValue; // Инициализируем минимальным значением double

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 1 == 0)
                    {
                        int integerPart = (int)Math.Floor(numbers[i]);
                        if (IsPrime(integerPart)) // Проверяем, является ли целая часть простым числом
                        {
                            if (numbers[i] > maxPrime) // Сравниваем с текущим максимумом
                            {
                                maxPrime = numbers[i];
                            }
                        }
                    }
                    
                }

                // Если maxPrime остался равным минимальному значению, значит простых чисел не было
                return maxPrime == double.MinValue ? 0 : maxPrime; // Возвращаем 0, если не найдено простых чисел
            }
        }

        private bool IsPrime(int num)
        {
            // Числа меньше 2 не являются простыми
            if (num < 2) return false;

            // Проверяем делимость только до квадратного корня из num
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false; // Найден делитель, число не простое
                }
            }

            return true; // Если делителей не найдено, число простое
        }
    }
}