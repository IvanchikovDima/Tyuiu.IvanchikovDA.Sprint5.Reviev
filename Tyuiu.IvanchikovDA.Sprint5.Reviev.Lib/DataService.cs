using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint5.Reviev.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V6.txt";



            string res = File.ReadAllText(path);
            char[] result = new char[res.Length];

            for (int i = 0; i < res.Length; i++)
            {
                char c = res[i];
                if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                {
                    result[i] = '#';
                }
                else
                {
                    result[i] = c;
                }
            }
            using (StreamWriter writer = new StreamWriter(pathSaveFile))
            {
                writer.Write(result);
            }
            return pathSaveFile;
        }
    }
}