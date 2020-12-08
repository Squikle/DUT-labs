namespace Lab_11._2
{
    public class Student
    {
        public delegate bool StudentPredicateDelegate(Student student);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool AgeCheck(Student student) => student.Age >= 18;
        public static bool FirstNameFirstLetterA(Student student) => student.FirstName?[0] == 'A';
        public static bool LastNameIsLongerThan3(Student student) => student.LastName?.Length > 3;

        public override string ToString()
        {
            return $"Имя: {FirstName}" +
                   $" Фамилия: {LastName}" +
                   $" Возраст: {Age}";
        }
    }
}
