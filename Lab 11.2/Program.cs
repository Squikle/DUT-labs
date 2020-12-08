using System;
using System.Collections.Generic;

namespace Lab_11._2
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            Random rand = new Random();

            int numberOfStudents = 15;
            for (int i = 0; i < numberOfStudents; i++)
            {
                students.Add(new Student
                {
                    Age = rand.Next(15, 25),
                    FirstName = GetRandomFirstName(rand),
                    LastName = GetRandomLastName(rand)
                });
            }
                

            Console.WriteLine("Все студенты:");
            students.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Старше 18");
            students.FindStudents(Student.AgeCheck).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Первая буква имени \"А\"");
            students.FindStudents(Student.FirstNameFirstLetterA).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Фамилия длинне 3 букв");
            students.FindStudents(Student.LastNameIsLongerThan3).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Старше 18");
            students.FindStudents(s => s.Age >= 18).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Первая буква имени \"А\"");
            students.FindStudents(s => s.FirstName?[0] == 'a').ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Фамилия длинне 3 букв");
            students.FindStudents(s => s.LastName?.Length > 3).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Возраст от 20 до 25");
            students.FindStudents(s => s.Age >= 20 && s.Age <= 25).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Имя \"Andrew\"");
            students.FindStudents(s => s.FirstName.Equals("Andrew")).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Фамилия \"Troelsen\"");
            students.FindStudents(s => s.LastName.Equals("Troelsen")).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.ReadKey();
        }

        private static string GetRandomFirstName(Random rand)
        {
            string[] names =
            {
                "James",
                "Andrew",
                "Robert",
                "Michael",
                "William",
                "Albert",
                "Elizabeth",
                "Adam",
                "Karen",
                "Jennifer",
                "Lisa",
                "Nancy",
            };
            return names[rand.Next(names.Length)];
        }
        private static string GetRandomLastName(Random rand)
        {
            string[] names =
            {
                "Baccari",
                "Zui",
                "MarBeltrancia",
                "Vang",
                "Baalman",
                "Lan",
                "Troelsen",
                "Moreno",
                "Collins",
                "Deleon",
                "Anderson",
                "Beltran",
            };
            return names[rand.Next(names.Length)];
        }
    }
}
