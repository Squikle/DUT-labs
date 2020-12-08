using System.Collections.Generic;

namespace Lab_11._2
{
    public static class Extensions
    {
        public static List<Student> FindStudents(this List<Student> students,
            Student.StudentPredicateDelegate studentFindPredicate)
        {
            List<Student> resultList = new List<Student>();
            foreach (var student in students)
            {
                if (studentFindPredicate(student))
                    resultList.Add(student);
            }
            return resultList;
        }
    }
}
