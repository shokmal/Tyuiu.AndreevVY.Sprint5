using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AndreevVY.Sprint5.Task5.V28.Lib;

using System.IO;

namespace Tyuiu.AndreevVY.Sprint5.Task5.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Андреев В.Ю. | Смарт-Б-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Андреев Владимир Юрьевич | Смарт-Б-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл) в                      *");
            Console.WriteLine("* котором есть набор значений. Найти факториал наименьшего целого числа, которое делится на 5, в файле. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\sokma\source\repos\Tyuiu.AndreevVY.Sprint5\Tyuiu.AndreevVY.Sprint5.Task5.V28\bin\Debug\InPutDataFileTask5V28.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("факториал наименьшего целого числа, которое делится на 5 = " + res);
            Console.ReadKey();
        }
    }
}
