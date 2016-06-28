namespace _02.BankAccounts
{
    using System;

    abstract class Customer
    {
        private string name;
        private string accountNumber;

        public Customer(string name, string accountNumber)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name can't be empty");
                }
                this.name = value;
            }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Account number name can't be empty");
                }
                this.accountNumber = value;
            }
        }
    }
}
