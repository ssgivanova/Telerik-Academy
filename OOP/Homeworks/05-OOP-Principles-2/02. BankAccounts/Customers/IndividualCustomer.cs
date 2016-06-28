namespace _02.BankAccounts
{
    using System;

    class IndividualCustomer : Customer
    {
        private string firstName;
        private string lastName;        

        public IndividualCustomer(string firstname, string lastName,string accountNumber)
            : base(firstname,accountNumber)
        {
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name can't be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name can't be empty");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Account number {0} : Customer {1} {2}", this.AccountNumber, this.FirstName, this.LastName);
        }
    }
}
