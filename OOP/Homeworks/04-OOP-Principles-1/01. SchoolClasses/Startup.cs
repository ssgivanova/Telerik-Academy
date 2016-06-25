namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            Teacher teacher1 = new Teacher("G-n Ivanov", new List<Discipline>(){new Discipline("Matematika",20,20),
                                                                                new Discipline("Fizika",18,16)});
            Teacher teacher2 = new Teacher("G-n Metodiev", new List<Discipline>() { new Discipline("Bulgarski ezik i literatura",20,15)});

            Student student1 = new Student("Kaloyan Mihailov", 15);
            Student student2 = new Student("Alexandra Pencheva", 1);
            Student student3 = new Student("Nikolai Ianakiev", 19);
            Student student4 = new Student("Qnica Nikolova", 22);
            Student student5 = new Student("Iskra Andreeva", 10);

            Class classA = new Class('A', new List<Student>() { student1, student2 }, new List<Teacher>() { teacher1 });
            Class classB = new Class('B', new List<Student>() { student3, student4, student5 }, new List<Teacher>() { teacher2,teacher1 });

            School mySchool = new School("12 OU",new List<Class>(){classA,classB});

        }
    }
}
