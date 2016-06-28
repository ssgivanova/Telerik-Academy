namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using Accounts;

    //A  bank  holds different types of accounts for its customers:  
    //deposit  accounts,  loan  accounts and  mortgage  accounts. 
    //Customers could be  individuals  or  companies .

    class BankSystem
    {
        private List<Account> accountsInBank;

        public BankSystem()
        {
            accountsInBank = new List<Account>();
        }

        public List<Account> AccountsInBank
        {
            get { return this.AccountsInBank; }
            set 
            {
                this.accountsInBank = value; 
            }
        }

        public void AddAcountToBank(Account account)
        {
            if (account != null)
            {
                this.AccountsInBank.Add(account);
            }
        }

        public void RemoveAcountToBank(Account account)
        {
            if (this.AccountsInBank.Count == 0)
            {
                throw new ArgumentException("No accounts in bank");
            }
            this.AccountsInBank.Remove(account);
        }
    }
}
