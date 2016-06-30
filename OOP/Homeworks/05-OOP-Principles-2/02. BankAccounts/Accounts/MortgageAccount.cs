namespace _02.BankAccounts.Accounts
{
    using System;

    //ipoteka
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interest) 
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

        //Mortgage accounts have ½ interest for the first  12  months for companies and no interest 
        //for the first  6  months for individuals.
        public override decimal CalculateInterest(int nbrMonths)
        {
            if (nbrMonths <= 0)
            {
                throw new ArgumentException("The number of months must be positive number");
            }

            decimal interest = 0;
            //calculate free months according type of customer
            int firstMonthsPromotion = 0;
            int nextMonthsWithFullInterest = 0;
            
            //calculate number of months for promotion
            if (this.Customer is IndividualCustomer)
            {
                firstMonthsPromotion = 6;
            }
            else if (this.Customer is CompanyCustomer)
            {
                firstMonthsPromotion = 12;
            }
            
            //for the month of promotion
            if (this.Customer is IndividualCustomer)
            {
                interest = 0;
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (nbrMonths <= firstMonthsPromotion)
                {
                    interest = nbrMonths * this.InterestRateMonthly / 2;
                }
                else
                {
                    interest = firstMonthsPromotion * this.InterestRateMonthly / 2;
                }
            }
            //add the remaining months with interest without promotion
            if (nbrMonths > firstMonthsPromotion)
            {
                nextMonthsWithFullInterest = nbrMonths - firstMonthsPromotion;
                interest += base.CalculateInterest(nextMonthsWithFullInterest);                
            }
            return interest;
        }
    }
}
