using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;

namespace Tyuiu.AndreevVY.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\sokma\source\repos\Tyuiu.AndreevVY.Sprint5\Tyuiu.AndreevVY.Sprint5.Task7.V21\bin\Debug\InPutDataFileTask7V21.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string new_str = "";
                string punctuation_marks = ",.!?-";
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!punctuation_marks.Contains(line[i]))
                        {
                            new_str += line[i];
                        }
                    }
                    File.WriteAllText(pathSaveFile, new_str);
                }
            }
            return pathSaveFile;
        }
    }
}
