namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class School
    {
        private List<Class> classesInSchool;
        public string Name { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.ClassesInSchool = new List<Class>();
        }

        public School(string name,List<Class> classes) : this(name)
        {
            this.ClassesInSchool = classes;
        }

       public List<Class> ClassesInSchool
        {
            get { return this.classesInSchool; }
            set
            {
                if (value != null)
                {
                    this.classesInSchool = value;
                }
            }
        }
    }
}
