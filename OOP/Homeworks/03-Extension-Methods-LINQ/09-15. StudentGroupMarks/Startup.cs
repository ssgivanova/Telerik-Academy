namespace _09_15.StudentGroupMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            //Problem 9. Student groups
            //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            //Create a List<Student> with sample students. Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.

            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", "FF1235677", 1,"ivanivan@gmail.com","+3592345678"));
            students.Add(new Student("Martin", "Marinov", "FF1256788", 2, "mpetrov@abv.bg", "+35932112233"));
            students.Add(new Student("Pesho", "Petrov", "FF1235699", 1, "peshkata@gmail.com", "02987654"));
            students.Add(new Student("Alexander", "Milanov", "FF1256804", 2, "amilanov@gmail.com", "3595645678"));

            //with LINQ
            var studentsFromGroup2 = students.Where(st => st.GroupNumber == 2)
                                             .OrderBy(st => st.FirstName)
                                             .Select(st => new { st.FirstName, st.LastName, st.FN })
                                             .ToList();

            foreach (var st in studentsFromGroup2)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + ", " + st.FN);
            }

            //Problem 10. Student groups extensions
            //implement the previous using the same query expressed with extension methods
            Console.WriteLine();
            var studentsFromGroup2Method = students.GetStudentsFromGivenGroup(2);
            foreach (var st in studentsFromGroup2Method)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + ", " + st.FN);
            }

            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.
            var studentsWithMailsGmail = students.GetStudentsByEmail("gmail.com");
            foreach (var st in studentsWithMailsGmail)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " - " +st.Email );
            }                                     


            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.Use LINQ.
            Console.WriteLine();
            var studentsFromSofia = students.GetStudentsByCity("+3592");
            foreach (var st in studentsFromSofia)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " : " + st.Tel);
            }

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class 
            //that has properties – FullName and Marks. Use LINQ.

            List<Student> students2 = new List<Student>();
            students2.Add(new Student("Ivan", "Ivanov", "FF1235677", 1, new List<int>() { 5, 6, 6, 5 }));
            students2.Add(new Student("Martin", "Marinov", "FF1256788", 2, new List<int>() { 4, 4, 3, 4 }));
            students2.Add(new Student("Pesho", "Petrov", "FF1235699", 1, new List<int>() { 4, 6, 5, 4 }));
            students2.Add(new Student("Alexander", "Milanov", "FF1256804", 2, new List<int>() { 6, 6, 6, 5 }));
            students2.Add(new Student("Georgi", "Naidenov", "FF1256800", 2, new List<int>() { 4, 3, 2, 2 }));

            var studentsWithExcellent = students2.GetStudentsWithExcellent();
            var studentsFullnamesAndMarks = new
            {
                FullName = studentsWithExcellent.Select(st => st.FirstName + " " + st.LastName),
                Marks = studentsWithExcellent.Select(st => st.Marks)
            };

   
            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            //var studentsWith2Marks2 = students.Where(x => x.Marks.Where(m => m==2).Count == 2).ToList();

            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 
            //06 as their 5-th and 6-th digit in the FN).
            //FF1205
            //FF1206
            students.Clear();
            students.Add(new Student("Ivan", "Ivanov", "FF12306", 1, new List<int>() { 5, 6, 6, 5 }));
            students.Add(new Student("Martin", "Marinov", "FF12406", 2, new List<int>() { 4, 4, 3, 4 }));
            students.Add(new Student("Pesho", "Petrov", "FF13204", 1, new List<int>() { 4, 6, 5, 4 }));
            students.Add(new Student("Alexander", "Milanov", "FF138005", 2, new List<int>() { 6, 6, 6, 5 }));

            Console.WriteLine("\nStudents from 2016");
            var studentsFrom2006 = students.Where(st => st.FN[5] == '0' && st.FN[6] == '6').Select(st =>
                new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                }).ToList();
            foreach (var st in studentsFrom2006)
            {
                Console.WriteLine(st.FullName + " - " + String.Join(",",st.Marks));
            }

            //Problem 18. Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them 
            //to the console.Use LINQ.

            students.Clear();
            students.Add(new Student("Ivan", "Ivanov", "FF12306", 1, new List<int>() { 5, 6, 6, 5 }));
            students.Add(new Student("Martin", "Marinov", "FF12406", 2, new List<int>() { 4, 4, 3, 4 }));
            students.Add(new Student("Pesho", "Petrov", "FF13204", 1, new List<int>() { 4, 6, 5, 4 }));
            students.Add(new Student("Alexander", "Milanov", "FF138005", 2, new List<int>() { 6, 6, 6, 5 }));

            // Problem 18-19. Grouped by GroupName
            var studentsByGroupNumberExtension = students.GroupBy(st => st.GroupNumber);

            var studentsByGroupNumber = students.OrderBy(st => st.GroupNumber).GroupBy(st => st.GroupNumber);

            foreach (var group in studentsByGroupNumber)
            {
                Console.WriteLine("\nGroup " + group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName +" "+student.LastName);
                }
            }    
        }
    }
}
