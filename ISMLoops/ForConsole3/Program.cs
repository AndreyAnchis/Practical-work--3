﻿using System;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите степень числа: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double res = 1;
                if (n > 0)
                {
                    for (double i = 1; i <= n; i++)
                    {
                        res = res * a;
                    }
                    Console.WriteLine(res);
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            Console.ReadKey();
        }
    }
}
