namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    abstract class Animal : ISound
    {
        //All animals are described by age, name and sex
        private int age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name,int age, SexType sex) :this(name,age)
        {
            this.Sex = sex;
        }
       
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0) throw new ArgumentException("Invalid animal age - age can't be negative");
                this.age = value;
            }
        }

        public string Name { get; set; }
        public SexType Sex { get; set; }

        public abstract string produceSound();

        public override string ToString()
        {
            string info = String.Format("My name is {0}, {1} years old ", this.Name, this.Age);
            string sexInfo = this.Sex == SexType.Female ? "female" : "male";
            return info + sexInfo;
        }

        public static double GetAverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(a => a.Age);
        }

    }
}
