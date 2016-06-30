namespace _02.BankAccounts.Accounts
{
    using System;

    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest) 
            : base(customer,balance,interest){}

        public void WithDraw(decimal amount) 
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount can't be negative number");
            }
            this.Balance -= amount;
        }

        //Desposit account can deposit and withdraw - negative balance is possible

        //Deposit accounts have no interest if their balance is positive and less than  1000 .
        public override decimal CalculateInterest(int nbrMonths)
        {
            if (nbrMonths <= 0)
            {
                throw new ArgumentException("The number of months must be positive number");
            }
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(nbrMonths);
            }
        }
    }
}
