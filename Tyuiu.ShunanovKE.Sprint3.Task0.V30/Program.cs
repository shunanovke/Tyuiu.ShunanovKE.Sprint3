using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint3.Task0.V30.Lib;


namespace Tyuiu.ShunanovKE.Sprint3.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#3 | Выполнил: Шунанов К. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шунанов Кирилл Ерболатович | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле:                                                        *");
            Console.WriteLine("*      20      k                                                          *");
            Console.WriteLine("*   p = П  (---------)                                                    *");
            Console.WriteLine("*      k=1        -10                                                     *");
            Console.WriteLine("*            sin(1)                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1, stopValue = 20;
            Console.WriteLine("startValue = 1  stopValue = 20");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
