using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Артём", 5);
            Student student1 = new Student("Сергей", 4.8);
            Student student2 = new Student("Женя", 4.3);
            Student student3 = new Student("Миша", 3.1);
            
            Group group = new Group();
            group.Name = "ИС31";
            group.College = "Мок 1-й";

            group.students.Add(student);
            group.students.Add(student1);
            group.students.Add(student2);
            group.students.Add(student3);
            group.ShowAll();
            Console.ReadLine();

        }
    }
}
