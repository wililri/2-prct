using System;
namespace dotnet_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, min, max, sym;
            sym = 0;
            min = 0;
            max = 0;
            Console.WriteLine("Введите первое число : ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число : ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число : ");
            z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("Большее число : " + x);
                    max = x;
                }
                else
                {
                    Console.WriteLine("Большее число : " + z);
                    max = z;
                }
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine("Большее число : " + y);
                    max = y;
                }
                else
                {
                    Console.WriteLine("Большее число : " + z);
                    max = z;
                }


                if (x < y)
                {
                    if (x < z)
                    {
                        Console.WriteLine("Меньшее число : " + x);
                        min = x;
                    }
                    else
                    {
                        Console.WriteLine("Меньшее число : " + z);
                        min = z;
                    }
                }
                else
                {
                    if (y < z)
                    {
                        Console.WriteLine("Меньшее число : " + y);
                        min = y;
                    }
                    else
                    {
                        Console.WriteLine("Меньшее число : " + z);
                        min = z;
                    }

                }
                sym = min + max;
                Console.WriteLine("Сумма меньшего и большего числа : " + sym);
            }


        }
    }
}
