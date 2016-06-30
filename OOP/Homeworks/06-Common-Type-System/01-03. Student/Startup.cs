namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Student s1 = new Student("Ivan", "Ivanov", "Ivanov", "12345678", "Sofia, Studentski Grad bl.59",
                "0888123456", "ivancho@abv.bg", 1, Faculty.KTT, University.TechnicalUniversity, Specialty.ComputerScience);

            Student s2 = new Student("Peter", "Ivanov", "Penchev", "54315678", "Sofia, jk.Obelia bl.100",
                "0888991199", "pesho_obelia@abv.bg", 2, Faculty.GraphicDesign, University.NBU, Specialty.ComputerGraphics);

            Student s3 = new Student("Martin", "Martinov", "Popov", "34789021", "Sofia, jk.Lulin bl.543",
                "0888786430", "mpopov@abv.bg", 4, Faculty.FMI, University.SofiaUniversity, Specialty.SofwareEngireening);

            Student s4 = new Student("Martin", "Martinov", "Popov", "34789021", "Sofia, jk.Lulin bl.543",
                "0888786430", "mpopov@abv.bg", 4, Faculty.FMI, University.SofiaUniversity, Specialty.SofwareEngireening);

            List<Student> students = new List<Student>() { s1, s2, s3, s4 };
                        
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 != s2);

            Console.WriteLine(s3.Equals(s4));
            Console.WriteLine(s3 == s4);
            Console.WriteLine(s3 != s4);

            Console.WriteLine();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            students.Sort();

            Console.WriteLine("\nsorted students");
            foreach (Student student in students)
            {
                Console.WriteLine(student.FullName + " " + student.Ssn);
            }
        }
    }
}
