using Tyuiu.BuzunovAI.Sprint1.Task0.V22.Lib;
namespace Tyuiu.BuzunovAI.Sprint1.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                DataService ds = new DataService();

                Console.Title = "Спринт #1| Выполнил: Бузунов А.И.| СМАРТб-25-1";
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("* Спринт #1                                                             *");
                Console.WriteLine("* Тема: Базовые навыки работы в C#                                      *");
                Console.WriteLine("* Задание #0                                                            *");
                Console.WriteLine("* Вариант #22                                                           *");
                Console.WriteLine("* Выполнил: Бузунов Андрей Ильич| СМАРТб-25-1                           *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                              *");
                Console.WriteLine("* Написать программу, которая вычисляет значение выражения 6*2-(5-3)    *");
                Console.WriteLine("* и выводит результат на экране.                                       *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("* 36/2/9+1-6/2*3                                                        *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
                Console.WriteLine("*************************************************************************");
                
                Console.WriteLine(ds.Calculate());

                Console.ReadLine();

            }
        }
    }
}