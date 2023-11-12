using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint4.Task6.V15.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#4 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание # 6                                                             *");
            Console.WriteLine("* Вариант # 15                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Чикаго, Хьюстон, Феникс, Филадельфия       *");
            Console.WriteLine("* Сан - Антонио, Сан - Диего, Даллас]      используя класс Array          *");
            Console.WriteLine("* подсчитайте количество элементов, длина которых меньше 7.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var cities = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("Исходный массив :");
            for ( int i = 0; i<= cities.Length - 1; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длинна которых меньше 7 : ");

            int nums = ds.Calculate(cities);

            Console.WriteLine(nums);
            Console.ReadKey();

        }
    }
}
