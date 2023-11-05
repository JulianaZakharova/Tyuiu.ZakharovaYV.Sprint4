using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint4.Task2.V20.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт#4 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание # 2                                                             *");
            Console.WriteLine("* Вариант # 20                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 7                                        *");
            Console.WriteLine("* подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numsArry[i] = rnd.Next(5, 20);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArry);

            Console.WriteLine("Сумма четных элементов =" + res);
            Console.ReadKey();

        }
    }
}
