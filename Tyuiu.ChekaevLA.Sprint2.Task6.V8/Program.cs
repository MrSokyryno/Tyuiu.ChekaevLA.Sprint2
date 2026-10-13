using Tyuiu.ChekaevLA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 2 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется двумя натуральными числами:*");
            Console.WriteLine("* n (порядковый номер месяца) и m (число). По заданным n и m определить   *");
            Console.WriteLine("* дату предыдущего дня (принять, что n и m не характеризуют 1 января).    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int N, M;
            Console.Write("Введите номер месяца: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер дня: ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Предыдущий день: {dataService.FindDateOfPreviousDay(M,N)}");

            Console.ReadKey();
        }
    }
}
