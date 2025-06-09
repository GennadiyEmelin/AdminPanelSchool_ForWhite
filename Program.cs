using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args) 
        {
            string SchoolName;//Наименование школы
            List<Students> students = new List<Students>(); //Список учеников
            SchoolName = FirstLaunch(); //присваивание имени школы при запуске

            while (true) //Цикл программы
            {
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Введите имя ученика: ");
                        string? Name = Console.ReadLine();
                        Console.WriteLine("Введите Фамилию ученика: ");
                        string? Surname = Console.ReadLine();
                        AddStudents(Name, Surname);
                        break;
                    case "2":
                        break;
                }
            }
        }

        static string FirstLaunch()
        {
            Console.WriteLine("Введите название школы: ");
            string? schoolName = Console.ReadLine();
            return schoolName;
        }

        static void AddStudents(string Name, string Surname)
        {
            
        }
    }
}
