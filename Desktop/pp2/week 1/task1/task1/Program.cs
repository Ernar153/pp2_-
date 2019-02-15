using System;
using System.Collections.Generic;
namespace Task_1
{
    class Program
    {
        //функция для проверки простых чисел
        public static bool check(string n)
        {
            //конвертируеm String в Int
            int num = int.Parse(n);
            if (num <= 1)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                    if (num % i == 0)
                        return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //создаем List для простых чисел
            List<string> primenum = new List<string>();
            //для считвания вводимой информации используем String
            string s1 = Console.ReadLine();
            //конвертируем String  в Int
            int n = int.Parse(s1);
            //Считываем String s2
            string s2 = Console.ReadLine();
            //добавляем числа в массив разделяя их 
            string[] arr = s2.Split();
            //используем for  для проверки каждого елемета массива на простые числа 
            for (int i = 0; i < n; i++)
            {
                if (check(arr[i]))
                // добавляем найденные простые числа массив 
                {
                    primenum.Add(arr[i]);
                }
            }//выводим количество простых чисел в массиве 
            Console.WriteLine(primenum.Count);
            //переносим елементы в String и разделяем их
            var cmb = string.Join(" ", primenum);
            //выводим простые числа в одной строке
            Console.WriteLine(cmb);
            Console.ReadKey();
        }
    }
}
