namespace _13.ExtractStudentsWithExcellentMarks
{
    using System;
    using System.Collections.Generic;

    //class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FN { get; private set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; private set; }
        private List<int> marks;

        public Student(string firstName, string lastName, string fn, int groupN)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.GroupNumber = groupN;
            marks = new List<int>();
        }

        public Student(string firstName, string lastName, string fn, int groupN, List<int> marks)
            : this(firstName, lastName, fn, groupN)
        {
            this.Marks = marks;
        }

        public List<int> Marks { get; set; }


    }
}
