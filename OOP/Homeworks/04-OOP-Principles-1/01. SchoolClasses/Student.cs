namespace _01.SchoolClasses
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Student : People, IComparable,IComment
    {
        private int uniqueNumber;
        //for testing if the number already exists
        private List<int> uniqueNumbers = new List<int>();

        public Student(string name, int number) : base(name)
        {
            this.UniqueNumber = number;
            this.Comments = String.Empty;

        }
        public int UniqueNumber
        {
            get { return this.uniqueNumber;}
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid student number - the number must be positive");
                }
                if (uniqueNumbers.Contains(value))
                {
                    throw new ArgumentException("This number is already in use by another student");
                }
                this.uniqueNumber = value;
                uniqueNumbers.Add(this.uniqueNumber);
           }
        }

        public string Comments { get; private set; }

        public int CompareTo(Object other)
        {
            Student otherStudent = (Student)other;
            if (this.UniqueNumber < otherStudent.UniqueNumber) { return -1; }
            if (this.UniqueNumber > otherStudent.UniqueNumber) { return 1; }
            return 0;
        }

        public void AddComment(string comment)
        {
            this.Comments += comment;
        }

        public void DeleteComments()
        {
            this.Comments = string.Empty;
        }
    }
}
