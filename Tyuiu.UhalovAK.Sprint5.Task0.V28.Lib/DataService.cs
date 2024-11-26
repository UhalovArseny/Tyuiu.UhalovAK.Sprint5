﻿using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;
namespace Tyuiu.UhalovAK.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            
            string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask0.txt";

            double z = x * (Math.Sqrt(x+3));
            z = Math.Round(z, 2);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
///(Math.Pow((x + 3), (1 / 2)))
