using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //вноси переменную для количества элементов
            int[] a = new int[n]; //создем массив с ограничителем n
            string[] ss = Console.ReadLine().Split(); //используем split  разделяя элементы
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(ss[i]); //переводим  string  в  int
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} {0} ", a[i]); //дублируем и выводим строку
            }
            Console.ReadLine();
        }
    }
}