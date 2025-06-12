using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название школы:");
            string schoolName = Console.ReadLine();

            School school = new School { Name = schoolName };

            Console.WriteLine($"Школа {school.Name} успешно создана.");

            while (true)
            {
                if (IsUserAgree($"\nХотите посмотреть список всех учеников школы {school.Name}?"))
                {
                    if (school.Students.Count == 0)
                    {
                        Console.WriteLine("Список учеников пуст.");
                    }
                    else
                    {
                        Console.WriteLine("Список учеников:");
                        foreach (var student in school.Students)
                        {
                            Console.WriteLine($"- {student}");
                        }
                    }
                }

                if (IsUserAgree($"\nХотите добавить нового ученика в школу {school.Name}?"))
                {
                    Console.Write("Введите имя ученика: ");
                    string FirstName = Console.ReadLine();
                    if (IsDigit(FirstName)) 
                    {
                        Console.WriteLine("Имя не может содержать цифры!");
                        return; 
                    }
                    string firstName = FirstName;

                    Console.Write("Введите фамилию ученика: ");
                    string LastName = Console.ReadLine();
                    if (IsDigit(LastName))
                    {
                        Console.WriteLine("Фамилия не может содержать цифры!");
                        return;
                    }
                    string lastName = LastName;

                    school.Students.Add(new Student { FirstName = firstName, LastName = lastName });

                    Console.WriteLine($"Ученик {firstName} успешно добавлен в школу {school.Name}.");
                }
            }
        }

        static bool IsUserAgree(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine().Trim().ToLower();
            return answer == "да" || answer == "yes" || answer == "y" || answer == "д";
        }

        static bool IsDigit(string answer)
        {
            char[] a = answer.ToCharArray();
            foreach (char c in a) 
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
