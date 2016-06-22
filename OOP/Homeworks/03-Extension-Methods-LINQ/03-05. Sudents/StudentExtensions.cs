namespace _03_05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StudentExtensions
    {
        public static IEnumerable<T> SortFirstNameBeforeLast<T>(this IEnumerable<T> students) where T: Student
        {
            return students.Where(st => st.FirstName.CompareTo(st.LastName) < 0).ToList();
        }

        public static IEnumerable<T> GetStudentsBetween18And24<T>(this IEnumerable<T> students) where T : Student
        {
            return students.Where(st => st.Age > 18 && st.Age < 24).ToList();
        }

        public static IEnumerable<T> OrderStudentsByNameLink<T>(this IEnumerable<T> students) where T : Student
        {
            return students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).ToList();
        }

        public static IEnumerable<T> OrderStudentsByName<T>(this IEnumerable<T> students) where T : Student
        {
            var sortedByNameStudents = from student in students
                                       orderby student.FirstName descending,student.LastName descending
                                       select student;
            return sortedByNameStudents;
        }
           

        

        
    }
}
