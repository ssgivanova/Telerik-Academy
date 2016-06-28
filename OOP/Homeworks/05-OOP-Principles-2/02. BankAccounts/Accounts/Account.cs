namespace _02.BankAccounts.Accounts
{
    //All accounts have customer, balance and interest rate (monthly based). ◦ 

    using System;

    abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRateMonthly;

        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRateMonthly = interest;
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set
            {
                if (value != null)
                {
                    this.customer = value;
                }
            }
        }

        //dont make check for negative value, deposit account permit negative balance
        public virtual decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRateMonthly
        {
            get { return this.interestRateMonthly; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Interest rate can't be negative");
                this.interestRateMonthly = value;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        //All accounts can calculate their interest amount for a given period (in months).
        public virtual decimal CalculateInterest(int nbrMonths)
        {
            return nbrMonths * this.interestRateMonthly;
        }

        public override string ToString()
        {
            return String.Format("{0}, balance : {1}lv - interest : {2}%", this.Customer, this.Balance, this.InterestRateMonthly);
        }
    }
}
