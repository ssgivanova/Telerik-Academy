namespace _02.BankAccounts.Accounts
{
    using System;

    //zaem
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest) 
            : base(customer,balance,interest){}

        //override property Balance - it can't be negative
        public override decimal Balance
        {
            get { return base.Balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Balance can't be negative in {0}", GetType().Name);
                this.Balance = value;
            }
        }

        //Loan accounts have no interest for the first  3  months if are held by individuals 
        //and for the first  2  months if are held by a company.

        public override decimal CalculateInterest(int nbrMonths)
        {
            //calculate free months according type of customer
            int firstFreeMonths = 0;
            int nextMonthsWithInterest = 0;

            if (this.Customer is IndividualCustomer)
            {
                firstFreeMonths = 3;
            }
            else if (this.Customer is CompanyCustomer)
            {
                firstFreeMonths = 2;
            }

            if (nbrMonths > firstFreeMonths)
            {
                nextMonthsWithInterest = nbrMonths - firstFreeMonths;
            }

            decimal interest = nextMonthsWithInterest * this.InterestRateMonthly;

            return interest;
        }
    }
}
