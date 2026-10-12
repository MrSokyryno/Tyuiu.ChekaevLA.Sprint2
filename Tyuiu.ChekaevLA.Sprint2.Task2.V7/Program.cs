using Tyuiu.ChekaevLA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 2 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int X, Y;
            Console.Write("Введите координату X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y: ");
            Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dataService.CheckDotInShadedArea(X, Y));

            Console.ReadKey();
        }
    }
}
