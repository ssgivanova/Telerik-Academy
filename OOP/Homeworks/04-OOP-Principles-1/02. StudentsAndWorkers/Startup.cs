namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order 
            //(use LINQ or OrderBy() extension method).
            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            //Merge the lists and sort them by first name and last name.

            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan","Ivanov",5));
            students.Add(new Student("Peter","Petrov",8));
            students.Add(new Student("Ilian","Ilievv",6));

            //sort by IComparable
            students.Sort();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nThe students");
            //sort by LINQ
            var studentsByGrade = students.OrderBy(st => st.Grade).Select(st => st).ToList();
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine(student);
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Hari", "Hamalina", 200,5));
            workers.Add(new Worker("Misho", "Zidaria", 150, 4));
            workers.Add(new Worker("Pesho", "Mazacha", 180, 5));
            workers.Add(new Worker("Sasho", "Nachalnika", 300, 5));

            Console.WriteLine("\nThe workers");
            //sort them by money per hour in descending order
            var workersByMoneyPerHours = workers.OrderByDescending(w => w.MoneyPerHour())
                                                .Select(w => new{
                                                    Name = w.FisrtName +" " +w.LastName,
                                                    Salary = w.WeekSalary,
                                                    Money = w.MoneyPerHour()
                                                }).ToList();
            foreach (var worker in workersByMoneyPerHours)
            {
                Console.WriteLine("{0} - {1:f2}lv/hour (weekly {2})",worker.Name,worker.Money,worker.Salary);
            }

            //Merge the lists and sort them by first name and last name.
            Console.WriteLine("\nAll the students and workers");
            List<Human> allPeople = new List<Human>();
            allPeople.AddRange(students);
            allPeople.AddRange(workers);

            var sortedPeople = allPeople.OrderBy(p => p.FisrtName).ThenBy(p => p.LastName).Select(p => p).ToList();
            foreach (var p in sortedPeople)
            {
                Console.WriteLine("{0} {1}", p.FisrtName,p.LastName);
            }
        }
    }
}
