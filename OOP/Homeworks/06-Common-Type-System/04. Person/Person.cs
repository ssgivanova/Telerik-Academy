namespace Person
{
    using System;
    using System.Text;

    class Person
    {
        //two fields – name and age.
        private string name;
        private int? age;

        public Person(string name, int? age = null) 
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Name must be specified");
                this.name = value;
            }
        }
        public int? Age
        {
            get 
            {
              return this.age;
            }
            private set
            {
              if (value <= 0 || value > 110) 
                {
                    throw new ArgumentException("Invalid age.Age must be positive number less than 110");
                }
                 //this.age = value.Value;
                this.age= value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" - ");            
            string ageInfo = age != null ? age.ToString() + "years" : "Age is not specified";
            sb.Append(ageInfo);
            return sb.ToString();
        }
              
    }
}
