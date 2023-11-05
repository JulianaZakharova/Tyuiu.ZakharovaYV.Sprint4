using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint4.Task3.V24.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
           

            DataService ds = new DataService();

            Console.Title = "Спринт#4 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание # 3                                                             *");
            Console.WriteLine("* Вариант # 24                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8.                          *");
            Console.WriteLine("* Найдите минимальный элемент во втором столбце массива.                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[,] array = new int[5, 5] { {3, 6, 1, 7, 3},
                                           {2, 3, 7, 1, 1},
                                           {1, 2, 5, 5, 1},
                                           {7, 6, 7, 6, 2},
                                           {7, 6, 4, 5, 8} };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Минимальный элемент во втором столбце = " + res);
            Console.ReadKey();
        }
    }
}
