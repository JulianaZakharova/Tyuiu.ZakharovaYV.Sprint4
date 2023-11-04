using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint4.Task0.V8.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#4 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание # 4                                                             *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива. {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            Console.WriteLine("* Исходный массив *");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Произведение четных элементов массива =" + ds.GetMultEvenArrEl(numsArray));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
