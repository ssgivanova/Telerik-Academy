namespace _02.BankAccounts
{
    using System;
    class CompanyCustomer : Customer
    {
        //private string companyName;
        private string bulstad;

        public CompanyCustomer(string companyName, string bulstad, string accountNumber)
            : base(companyName, accountNumber)
        {
            this.Bulstad = bulstad;
        }

        public string Bulstad
        {
            get { return this.bulstad; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Bulstad name can't be empty");
                }
                this.bulstad = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Account number {0} : Customer : {1} - bulstad :{2}", this.AccountNumber,this.Name, this.Bulstad);
        }

    }
}
