using Tyuiu.KiselevEA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.KiselevEA.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Киселев Е. А. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Киселев Егор Алексеевич | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую задачу                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1 = 3;
            double v2 = 2;
            double S = 6;
            double T = 30;

            Console.WriteLine("Скорость первого автомобиля = " + v1);
            Console.WriteLine("Скорость Второго автомобиля = " + v2);
            Console.WriteLine("Время = " + T);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Растояние между машинами = " + ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadKey();
        }
    }
}
