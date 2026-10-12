using System;
using Tyuiu.ChekaevLA.Sprint2.Task1.V9.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 2 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность*");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (False, False,    *");
            Console.WriteLine("* True, False, True, False), при a = 15, b = 335, c = 174, d = 478        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a=15                                                                    *");
            Console.WriteLine("* b=335                                                                   *");
            Console.WriteLine("* c=174                                                                   *");
            Console.WriteLine("* d=478                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = dataService.GetLogicOperations(15, 335, 174, 478);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }}
