namespace _03.AnimalHierarchy
{
    class Cat : Animal
    {

        public Cat(string name, int age)
            : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Cat(string name, int age, SexType sex)
            : this(name, age)
        {
           this.Sex = sex;
        }

        public override string produceSound()
        {
            return "Miao miao!";
        }
    }
}
