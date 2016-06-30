namespace Student
{
    using System;

   //Define a class  Student , which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
   //Override the standard methods, inherited by  System.Object :  Equals() ,  ToString() ,  GetHashCode()  and operators  ==  and  != .
    
    class Student : ICloneable,IComparable<Student>
    {

        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private int course;

        public Student(){} 

        public Student(string firstName, string middleName, string lastName, string ssn, 
            string address, string gsm, string email, int course, Faculty faculty, University university,
            Specialty specialty)
            : this(firstName,middleName,lastName,ssn,course,faculty,university,specialty)
        {
            this.PermanentAddress = address;
            this.MobilePhone = gsm;
            this.Email = email;
        }

        public Student(string firstName, string middleName, string lastName, string ssn, int course,
                       Faculty faculty, University university,Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Course = course;
            this.Faculty = faculty;
            this.University = university;
            this.Specialty = specialty;
        }


        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Fistname can't be empty");
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Middlename can't be empty");
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Lastname can't be empty");
                this.lastName = value;
            }
        }
        public string Ssn
        {
            get { return this.ssn; }
            private set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("SSN can't be empty");
                this.ssn = value;
            }
        }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email {get;set;}
        public int Course
        {
            get { return this.course; }
            private set
            {
                if (value < 1 || value > 5) throw new ArgumentNullException("Courses are only from 1 to 5.");
                this.course = value;
            }
        }
        public Specialty Specialty {get;private set;}
        public University University {get;private set;}
        public Faculty Faculty {get;private set;}

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.MiddleName + " " + this.LastName;
            }
        }

        // System.Object :  Equals() ,  ToString() ,  GetHashCode()  and operators  ==  and  != .

        public override string ToString()
        {
            return String.Format("Student :\n{0} {1} {2}, {3},{4},{5} - {6} course", this.FirstName, this.MiddleName,
                this.LastName, this.University, this.Faculty, this.Specialty, this.course);
        }

        //proverka na vsichki propertita
        //public override bool Equals(Object other)
        //{
        //    if (Object.ReferenceEquals(other, null)) { return false; }
        //    Student otherStudent = (Student)other;
        //    if (this.FirstName.Equals(otherStudent.FirstName)) return false;
        //    if (!this.MiddleName.Equals(otherStudent.MiddleName)) return false; 
        //    if (!this.LastName.Equals(otherStudent.LastName)) return false;
        //    if (!this.Ssn.Equals(otherStudent.Ssn)) return false;
        //    if (!this.PermanentAddress.Equals(otherStudent.PermanentAddress)) return false;
        //    if (!this.MobilePhone.Equals(otherStudent.MobilePhone)) return false;
        //    if (!this.Email.Equals(otherStudent.Email)) return false;
        //    if (!this.Course.Equals(otherStudent.Course)) return false;
        //    if (!this.University.Equals(otherStudent.University) ) return false;
        //    if (!this.Faculty.Equals(otherStudent.Faculty)) return false;
        //    if (!this.Specialty.Equals(otherStudent.Specialty)) return false;

        //    return true;
        //}

        //sykraten equals - samo imenata i socialna usigorovka
        public override bool Equals(Object other)
        {
            if (other == null) { return false; }
            Student otherStudent = (Student)other;

            if (!this.FullName.Equals(otherStudent.FullName)) return false;
            if (!this.Ssn.Equals(otherStudent.Ssn)) return false;

            return true;
        }
        
        public static bool operator == (Student s1,Student s2)
        {
            if (Object.ReferenceEquals(s1, null))
            {
                return false;
            }
            else
            {
                return s1.Equals(s2);
            }
        }

        public static bool operator != (Student s1,Student s2)
        {
            return !(s1 == s2);
        }

        public override int GetHashCode()
        {
            return ((this.Ssn.GetHashCode() * 397) ^ (this.FirstName + this.MiddleName + this.LastName).GetHashCode());
        }

        public object Clone()
        {
            //deeply copy all object's fields into a new object of type  Student .

            Student newStudent = new Student();
            newStudent.FirstName = this.FirstName;
            newStudent.MiddleName = this.MiddleName;
            newStudent.LastName = this.LastName;
            newStudent.Ssn = this.Ssn;
            newStudent.PermanentAddress= this.PermanentAddress;
            newStudent.MobilePhone = this.MobilePhone;
            newStudent.Email = this.Email;
            newStudent.Course = this.Course;
            newStudent.University = this.University;
            newStudent.Faculty = this.Faculty;
            newStudent.Specialty = this.Specialty;
            return newStudent;
        }

        //compare students by names (as first criteria, in lexicographic order)
        //and by social security number (as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
            if (this.FullName.CompareTo(other.FullName) == 0)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }
            else
            {
                return this.FullName.CompareTo(other.FullName);
            }
        }

        public int CompareTo(Object other)
        {
            Student otherStudent = other as Student;
            if (otherStudent == null)
            { return -1; }
            else
            {
                if (this.FullName.CompareTo(otherStudent.FullName) == 0)
                {
                    return this.Ssn.CompareTo(otherStudent.Ssn);
                }
                else
                {
                    return this.FullName.CompareTo(otherStudent.FullName);
                }
            }
        }

    }
}
