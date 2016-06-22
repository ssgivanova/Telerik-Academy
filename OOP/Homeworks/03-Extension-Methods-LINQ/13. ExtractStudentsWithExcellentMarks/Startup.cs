namespace _13.ExtractStudentsWithExcellentMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        //Select all students that have at least one mark Excellent (6) into a new anonymous class 
        //that has properties – FullName and Marks.Use LINQ.
        //another solution

        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", "FF1235677", 1, new List<int>() { 5, 6, 6, 5 }));
            students.Add(new Student("Martin", "Marinov", "FF1256788", 2, new List<int>() { 4, 4, 3, 4 }));
            students.Add(new Student("Pesho", "Petrov", "FF1235699", 1, new List<int>() { 4, 6, 5, 4 }));
            students.Add(new Student("Alexander", "Milanov", "FF1256804", 2, new List<int>() { 6, 6, 6, 5 }));
            students.Add(new Student("Georgi", "Naidenov", "FF1256800", 2, new List<int>() { 4, 3, 2, 2 }));

            Console.WriteLine("Students with excellent marks");
            var studentsWithExcellent = students.FindAll(st => st.Marks.Contains(6)).Select(st => 
                new {
                      FullName = st.FirstName + " " + st.LastName, Marks = st.Marks
                    }).ToList();

            foreach (var st in studentsWithExcellent)
            {
                Console.Write(st.FullName + ":");
                foreach (var mark in st.Marks)
                {
                    Console.Write(mark +" ");
                }
                Console.WriteLine();
            }

        }
    }
}
