using System;
using System.IO;
namespace Task3
{
    class Program
    {
        public static void showspaces(int level)//вывод пробелов 
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write(" ");
            }
        }
        public static void showDirectory(DirectoryInfo d, int level)
        {
            FileInfo[] fi = d.GetFiles();//помещаем файлы в массив 
            DirectoryInfo[] di = d.GetDirectories();//помещаем директивы в массив 

            foreach (FileInfo f in fi) // сначала выводим все файлы 
            {
                showspaces(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo directory in di) //выводим директории
            {
                showspaces(level);
                Console.WriteLine(directory.Name);
                showDirectory(directory, level + 1);

            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Asus\Pictures\PhotoDirector");////строка пути 
            showDirectory(d, 0);
            Console.ReadKey();
        }
    }
}