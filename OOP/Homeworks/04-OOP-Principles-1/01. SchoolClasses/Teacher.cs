namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class Teacher : People, IComment
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {
            disciplines = new List<Discipline>();
            this.Comments = String.Empty;
        }

        public Teacher(string name, List<Discipline> disciplines)
            : this(name)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines;}
            set 
            {
                if (value != null)
                {
                    this.disciplines = value;
                }
            }
        }

        public string Comments { get; set; }

        public void AddDiscipline(Discipline newDiscipline)
        {
            if (newDiscipline != null)
            {
                this.Disciplines.Add(newDiscipline);
            }
        }

        public void RemoveDiscipline(Discipline newDiscipline)
        {
            if (newDiscipline != null)
            {
                this.Disciplines.Remove(newDiscipline);
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
