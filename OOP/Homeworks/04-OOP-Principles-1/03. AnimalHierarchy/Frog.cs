namespace _03.AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, int age, SexType sex)
            : base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public override string produceSound()
        {
            return "Kva kva!";
        }
    }
}
