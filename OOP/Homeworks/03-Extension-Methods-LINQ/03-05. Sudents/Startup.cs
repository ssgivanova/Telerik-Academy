namespace _03_05.Students
{
    using System;
    using System.Linq;
    
    class Startup
    {
        static void Main()
        {
            //Problem 3. First before last
            //Write a method that from a given array of students finds all students whose 
            //first name is before its last name alphabetically.
            //Use LINQ query operators.

            //var students = new[] { new {FirstName = "Ivan",LastName = "Ivanov" },
            //                       new {FirstName = "Petyr",LastName = "Malinov" },
            //                       new {FirstName = "Marin",LastName = "Petrov" },
            //                    };
            //var sortedStudents = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0).ToList();

            Student[] students = new Student[]{ new Student("Ivan","Ivanov",20),
                                                new Student("Petyr","Malinov",21),
                                                new Student("Marin","Petrov",25),
                                                new Student("Alexander","Krasimirov",18),
                                                new Student("Marin","Alexandrov",22),
                                    };
                      
            var sortedStudents = students.SortFirstNameBeforeLast();

            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            //Problem 4. Age range
            //Write a LINQ query that finds the first name and last name of all students with age 
            //between 18 and 24.
            Console.WriteLine();
            var studentsBetween18And24 = students.GetStudentsBetween18And24();
            foreach (var st in studentsBetween18And24)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            //Problem 5. Order students
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort 
            //the students by first name and last name in descending order.
            //Rewrite the same with LINQ.
            Console.WriteLine();
            var sortedByNameStudents = students.OrderStudentsByNameLink();
            //var sortedByNameStudents = students.OrderStudentsByName();
            foreach (var st in sortedByNameStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            

        }
    }
}
