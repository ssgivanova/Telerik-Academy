namespace _02.StudentsAndWorkers
{
    using System;

    abstract class Human
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.FisrtName = firstName;
            this.LastName = lastName;
        }
    }
}
