namespace _02.StudentsAndWorkers
{
    using System;

    class Worker : Human
    {
        //Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and 
        //a method MoneyPerHour() that returns money earned per hour by the worker. 

        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName) : base(firstName, lastName) { }

        public Worker(string firstName, string lastName,decimal weekSalary) : this(firstName, lastName) 
        {
            this.WeekSalary = weekSalary;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : this(firstName, lastName,weekSalary)
        {
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0) throw new ArgumentException("Salary can't be negative");
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0) throw new ArgumentException("Work hours can't be negative");
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            //saturday and sunday are day off - 5 working days
            decimal moneyPerDay = this.WeekSalary / 5;
            decimal moneyPerHour = moneyPerDay / (decimal)this.WorkHoursPerDay;
            return moneyPerHour;
        }

    }
}
