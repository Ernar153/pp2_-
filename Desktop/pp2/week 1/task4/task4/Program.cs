﻿using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //считываем число для цикла
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("[*]"); //выводим *
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}