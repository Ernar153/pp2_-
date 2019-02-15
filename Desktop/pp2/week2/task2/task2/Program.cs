using System;
using System.IO;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\eSupport\eDriver\input1.txt");//считываем файл
            string s = sr.ReadLine();//вносим в string
            StreamWriter sw = new StreamWriter(@"C:\eSupport\eDriver\output.txt");
            string[] arr = s.Split();//используем split  разделем элементы
            for (int i = 0; i < arr.Length; i++)//проходимся по элементам массива
            {
                int number = int.Parse(arr[i]);//первращаем в int
                bool test = true;
                for (int j = 2; j <= Math.Sqrt(number); j++)
                {
                    if (number % j == 0)//проверяем на простые числа 
                    {
                        test = false;
                        break;//останавливаем цикл в случае  не соответствия 
                    }
                }
                if (test && number != 1) //выводм элементы если они  простые и не равны одному 
                {
                    sw.Write(number + " "); //выводим через пробел

                }
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}