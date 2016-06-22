namespace _03_05.Students
{
    using System;
    using System.Collections.Generic;

    //class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    public class Student
    {
        private int age;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age 
        { get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0) { throw new ArgumentException("Invalid age"); }
                this.age = value;
            }
        }
        public string FN { get; private set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; private set; }
        private List<int> marks;

        public Student(string firstName, string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            marks = new List<int>();
        }

        public Student(string firstName, string lastName, int age,string fn, int groupN) : this(firstName,lastName,age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.GroupNumber = groupN;
            marks = new List<int>();
        }

        public Student(string firstName, string lastName, int age,string fn, int groupN,List<int> marks)
            :this(firstName,lastName,age,fn,groupN)
        {
            this.Marks = marks;
        }

        public List<int> Marks {get;set;}


    }
}
