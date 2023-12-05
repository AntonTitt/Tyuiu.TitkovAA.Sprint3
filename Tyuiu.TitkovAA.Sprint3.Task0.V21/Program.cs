using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint3.Task0.V21.Lib;

namespace Tyuiu.TitkovAA.Sprint3.Task0.V21
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #3 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по  *");
            Console.WriteLine("* формуле, при a=1,5                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 1.5 startValue=1 stopValue=13                                       *");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService dt = new DataService();

            Console.WriteLine(dt.GetSumSeries(1.5, 1, 13));



            Console.ReadKey();






        }
    }
}
