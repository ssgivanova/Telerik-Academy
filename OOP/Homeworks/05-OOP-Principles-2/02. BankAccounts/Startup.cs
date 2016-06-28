namespace _02.BankAccounts
{
       /*
 A  bank  holds different types of accounts for its customers:  
  deposit  accounts,  loan  accounts and  mortgage  accounts. 
  Customers could be  individuals  or  companies .
• All accounts have customer, balance and interest rate (monthly based). ◦ 
     * 
  Deposit accounts are allowed to deposit and with draw money.
◦ Loan and mortgage accounts can only deposit money.

• All accounts can calculate their interest amount for a given period (in months). 
  In the common case its is calculated as follows:  number_of_months  *  interest_rate .
• Loan accounts have no interest for the first  3  months if are held by individuals 
  and for the first  2  months if are held by a company.
• Deposit accounts have no interest if their balance is positive and less than  1000 .
• Mortgage accounts have ½ interest for the first  12  months for companies and no interest 
  for the first  6  months for individuals.
• Your task is to write a program to model the bank system by classes and interfaces.
• You should identify the classes, interfaces, base classes and abstract actions and 
  implement the calculation of the interest functionality through overridden methods.
*/

    using Accounts;
    using System;
    using System.Collections.Generic;
    
    class Startup
    {
        static void Main()
        {
            BankSystem bank = new BankSystem();

            Customer ivan = new IndividualCustomer("Ivan", "Ivanov", "RBBF1234566777");
            Customer myCompany = new CompanyCustomer("My Company", "BG12345", "RBBF1212566599");

            DepositAccount depositAccountIvan = new DepositAccount(ivan, 0, 5);
            depositAccountIvan.WithDraw(100);
            depositAccountIvan.Deposit(1200);

            Account loanAccountIvan = new LoanAccount(ivan, 2000, 3);
            Account loanAccountCompany = new LoanAccount(myCompany, 50000, 2);
            Account mortgageAccountIvan = new MortgageAccount(ivan, 30000, 8);
            Account mortgageAccountCompany = new MortgageAccount(myCompany, 100000, 5);

            List<Account> accounts = new List<Account>(){depositAccountIvan, 
                                                        loanAccountIvan, loanAccountCompany,
                                                        mortgageAccountIvan, mortgageAccountCompany};

            System.Console.WriteLine("Accounts in the bank :\n");
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
                decimal interestFor6Months = account.CalculateInterest(14);
                decimal amountInterest = account.Balance * (interestFor6Months / 100);
                //Console.WriteLine("interest for 6 months : {0}%",interestFor6Months);
                Console.WriteLine("interest for 6 months : {0}% -> {1:f2}lv", interestFor6Months,amountInterest);
            }
        }
    }
}
