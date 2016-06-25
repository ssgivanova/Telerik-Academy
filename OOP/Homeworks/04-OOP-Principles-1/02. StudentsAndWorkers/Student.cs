namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student : Human, IComparable
    {
        private int grade; //klas

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 1 || value > 13) throw new ArgumentException("Grade must be between 1 and 12");
                this.grade = value;
            }
        }

        public Student(string firstName,string lastName, int grade)
            : base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2} class", this.FisrtName, this.LastName, this.Grade);
        }

        public int CompareTo(object obj)
        {
            Student other = (Student)obj;

            if (this.Grade.CompareTo(other.Grade) < 0) { return -1; }
            if (this.Grade.CompareTo(other.Grade) > 0) { return 1; }
            else { return 0; }
        }
    }
}
