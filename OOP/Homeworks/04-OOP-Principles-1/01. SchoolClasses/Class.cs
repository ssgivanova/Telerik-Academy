namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class Class : IComment
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private char identifier;
        private List<char> classIdentifiers = new List<char>();

        public Class(char ident)
        {
            this.Identifier = ident;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            this.Comments = String.Empty;
        }

        public Class(char ident, List<Student> students,List<Teacher> teachers) : this(ident)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.Comments = String.Empty;
        }

        public string Comments { get; set; }

        public char Identifier
        {
            get { return this.identifier; }
            private set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentOutOfRangeException("Invalid class identifier");
                }
                if (classIdentifiers.Contains(value))
                {
                    throw new ArgumentException("This class id is already in use by another class");
                }
                this.identifier = value;
                classIdentifiers.Add(this.identifier);
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value != null)
                {
                    this.students = value;
                }
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                if (value != null)
                {
                    this.teachers = value;
                }
            }
        }

        private bool validateClass(char classId)
        {

            return true;
        }

        public void AddStudentToClass(Student newStudent)
        {
            if (newStudent!= null)
            {
                this.Students.Add(newStudent);
            }
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
