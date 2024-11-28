﻿using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.UhalovAK.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            int maxPrime = int.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int number;
                    if (int.TryParse(line, out number) && IsPrime(number))
                    {
                        if (number > maxPrime)
                        {
                            maxPrime = number;
                        }
                    }
                }
            }

            return maxPrime;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
