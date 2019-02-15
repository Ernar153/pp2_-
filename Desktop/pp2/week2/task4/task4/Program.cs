using System;
using System.IO;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\PP2\Week2\Task4\input1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            fs.Close();

            File.Copy(@"C:\PP2\Week2\Task4\input1.txt", @"C:\PP2\Week2\Task4\copy.txt");

            File.Delete(@"C:\PP2\Week2\Task4\input1.txt");


        }
    }
}
