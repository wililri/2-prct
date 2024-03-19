using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите единицу измерения: ");
        int y = Convert.ToInt32(Console.ReadLine());

        switch (y)
        {
            case 1:
                x = x / 10;
                Console.WriteLine("Длина из дм в м:  {0:f3}", x); break;
            case 2:
                x = x * 1000;
                Console.WriteLine("Длина из км в м:  {0:f3}", x); break;
            case 3:
                x = x / 1000;
                Console.WriteLine("Длина из мм в м:  {0:f3}", x); break;
            case 4:
                x = x / 100;
                Console.WriteLine("Длина из см в м:  {0:f3}", x); break;
            default: Console.WriteLine("Недоступная длина!!!"); break;
        }
    }
}
