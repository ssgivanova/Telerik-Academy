namespace _03.AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, int age, SexType sex)
            : base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public override string produceSound()
        {
            return "Aff aff!";
        }
    }
}
