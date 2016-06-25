namespace _03.AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age)
        {
            this.Sex = SexType.Female;
        }

    }
}
