namespace _09_15.StudentGroupMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentExtensions
    {
        public static IEnumerable<T> GetStudentsFromGivenGroup<T>(this IEnumerable<T> students, int groupNumber)
            where T : Student
        {
            var result = from student in students
                         where student.GroupNumber == groupNumber
                         orderby student.FirstName
                         select student;
            return result;
        }

        //Problem 11. Extract students by email
        public static IEnumerable<T> GetStudentsByEmail<T>(this IEnumerable<T> students, string emailDomain)
            where T : Student
        {
            var result = students.Where(st => st.Email.Contains(emailDomain)).ToList();
            return result;
        }

        //Problem 12. Extract students by phone in Sofia
        public static IEnumerable<T> GetStudentsByCity<T>(this IEnumerable<T> students, string cityTelCode)
            where T : Student
        { 
            string searchCode=cityTelCode;
            //search for 02 for Sofia

            //if code starts with +359
            if(!cityTelCode.StartsWith("0"))
            {
                searchCode = "0"+cityTelCode.Substring(4);
                
            }
            //Console.WriteLine(searchCode);
            var result = students.Where(st => st.Tel.StartsWith(searchCode) || st.Tel.StartsWith(cityTelCode)).ToList();
            return result;
        }

        public static IEnumerable<T> GetStudentsWithExcellent<T>(this IEnumerable<T> students)
            where T : Student
        {
            var result = students.Where(st => st.Marks.Any(m => st.Marks.Contains(6))).ToList();
            return result;
        }

        //public static IEnumerable<T> GetStudentsWith2Marks2<T>(this IEnumerable<T> students)
        //   where T : Student
        //{
        //    var studentsWithMark2 = students.Where(x => x.Marks.Where(m => m == 2).Count == 2).ToList();
        //    return studentsWithMark2;
        //}

        public static IEnumerable<IGrouping<int, T>> StudentsByGroups<T>(IEnumerable<T> students) where T : Student
        {
            var result = students
                .OrderBy(x => x.GroupNumber)
                .GroupBy(x => x.GroupNumber);
            return result;
        }
        
    }
}
