using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;

            if (x > 3)
                y = 1.2 * x * x - (3 * x) - 9;

            else
                y = 12.1 / (2 * (Math.Pow(x, 2) + 1));

            Console.WriteLine("Для x = {0:f2} ", x);
            Console.WriteLine("Результат = {0:f2} ", y);
        }
    }
}
