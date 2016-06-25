namespace _01.SchoolClasses
{
    class Discipline
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; } //todo priverka za < 0
        public int NumberOfExercises { get; set; }

        public Discipline(string name, int numberLectures, int numberExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberLectures;
            this.NumberOfExercises = NumberOfExercises;
        }
    }
}
