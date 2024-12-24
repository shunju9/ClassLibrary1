using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double ocenka;
        public Student(string name, double ocenka)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Ocenka = ocenka;
        }
        public double Ocenka
        {
            get { return ocenka; }
            set { ocenka = value; }
        }
        public void Show()
        {
            Console.WriteLine($"Имя{Name},Оценка{Ocenka}");
        }
    }
}
public class Group
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string College;
    public List<Student> students = new List<Student>();
    public void ShowAll()
    {
        Console.WriteLine($" Название группы{Name}," + $" Колледж {College}\n Список студентов:");
        foreach (Student student in students)
        {
            student.Show();
        }
    }
}

