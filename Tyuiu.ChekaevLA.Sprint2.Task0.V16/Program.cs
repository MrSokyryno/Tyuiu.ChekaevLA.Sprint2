using Tyuiu.ChekaevLA.Sprint2.Task0.V16.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 2 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
            Console.WriteLine("* (True, False, True, False, True, False), при x = 1025, y = 275          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X=1025                                                                  *");
            Console.WriteLine("* Y=275                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int X = 1025;
            int Y = 275;
            bool[] res = dataService.GetCompareOperations(X, Y);

            for (int i = 0; i<6;i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
