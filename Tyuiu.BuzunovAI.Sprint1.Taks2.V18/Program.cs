using Tyuiu.BuzunovAI.Sprint1.Taks2.V18.Lib;
namespace Tyuiu.BuzunovAI.Sprint1.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1| Выполнил: Бузунов А.И.| СМАРТб-25-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                      *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнил: Бузунов Андрей Ильич| СМАРТб-25-1                           *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные*");
            Console.WriteLine("* ,вычисляет результат по формуле (x+y)/x*y и печатает его на экране.   *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");

            int value;
            int valueTwo;
            int valueThree;

            Console.WriteLine("Введите длину параллелепипеда:");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину параллелепипеда:");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите высоту параллелепипеда:");
            valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Площадь боковой поверхности параллелепипеда равна:" + ds.CalculateSideSquareParallelepiped(value, valueTwo, valueThree));

            Console.ReadLine();
        }
    }
}