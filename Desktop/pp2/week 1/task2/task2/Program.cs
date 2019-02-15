using System;

namespace Task2
{
    class Program
    {
        class Student//создаем класс
        {
            string name, id;//составляющие класса  имя id  год
            int year = 0;

            public Student(string name, string id)//constructor с двумя параметрами имя  и id
            {
                this.name = name;
                this.id = id;

            }
            public void toPrint()//methodдля вывода  имени и id  студента 
            {
                Console.WriteLine("Name of student :{0} ", name);
                Console.WriteLine("ID of student: " + id);
            }
            public void increment()//method для вывода года обучения
            {
                this.year++;
                Console.WriteLine("Year of student increased by one, now is {0}", year);
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Ernar", "18BD110418");//создаем 
            s1.toPrint(); //вызов метода для вывода информации о студенте
            s1.increment();//вызов метола для вывода года обучения
            Console.ReadKey();
            //Console.ReadKey();
        }
    }
}