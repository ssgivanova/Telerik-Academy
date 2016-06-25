namespace _03.AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Sex = SexType.Male;
        }
    }
}
