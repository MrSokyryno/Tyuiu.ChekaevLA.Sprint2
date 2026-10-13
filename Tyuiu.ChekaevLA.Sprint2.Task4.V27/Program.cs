using Tyuiu.ChekaevLA.Sprint2.Task4.V27.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 2 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x,y с клавиатуры, если x-10>y+2, то z=x((y+2)/(x-1))^x иначе *");
            Console.WriteLine("* y^2 - (2/x). Ответ округлите до 3 знаков после запятой                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double X, Y;
            Console.Write("Введите X: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите X: ");
            Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Z = {dataService.Calculate(X, Y)}");

            Console.ReadKey();
        }
    }
}
