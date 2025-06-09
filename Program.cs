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
            Console.WriteLine($"Школа {SchoolName} успешно создана");

            while (true) //Цикл программы
            {
                Console.WriteLine("Хотите посмотреть список всех учеников школы?");
                string? input = Console.ReadLine();//Команда пользователя
                switch (input)
                {
                    case "да" or "Да":
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine($"Ученик: {i + 1}");
                            Console.WriteLine($"Имя: " + students[i].Name);
                            Console.WriteLine($"Фамилия: " + students[i].Surname);
                        }
                        Console.WriteLine("Хотите добавить нового ученика?");
                        string? input_2 = Console.ReadLine();
                        switch (input_2)
                        {
                            case "Да" or "да":
                                Console.WriteLine("Введите имя ученика: ");
                                string? NameStudent = Console.ReadLine();
                                Console.WriteLine("Введите фамилию ученика: ");
                                string? SurnameStudent = Console.ReadLine();
                                students.Add(new Students(NameStudent, SurnameStudent));
                                Console.WriteLine($"Ученик {NameStudent} успешно добавлени в {SchoolName}");
                                break;
                            case "Нет" or "нет":
                                break;
                        }
                        break;
                    case "Нет" or "нет":
                        return;
                }
            }
        }

        static string FirstLaunch()//Первый запуск
        {
            Console.WriteLine("Введите название школы: ");
            string? schoolName = Console.ReadLine();
            return schoolName;
        }
    }
}
