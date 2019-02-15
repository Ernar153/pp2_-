using System;
using System.IO;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //считываем файл
            StreamReader sr = new StreamReader(@"C:/PP2/Week2/Task1/input.txt");
            string s;
            //считываем строки с файла 
            while ((s = sr.ReadLine()) != null)
            {
                //переносим строки в char формат
                char[] chararray = s.ToCharArray();
                //"переворачиваем " массив 
                Array.Reverse(chararray);
                //массив вносим в string
                string check = new string(chararray);
                if (check == s)// используем if для проверки массива и первоначальной неизмененной строки 
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");

            }
            Console.ReadKey();
        }
    }
}
