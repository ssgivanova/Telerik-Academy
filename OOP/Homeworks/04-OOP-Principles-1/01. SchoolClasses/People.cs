namespace _01.SchoolClasses
{
    using System;

    class People
    {
        private string name;

        public People(string name)
        { }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty.");
                }
                this.name = value;   
            }
        }
    }
}
