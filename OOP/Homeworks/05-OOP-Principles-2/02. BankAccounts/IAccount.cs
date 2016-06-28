namespace _02.BankAccounts
{
    public interface IAccount
    {
        decimal CalculateInterest(int nbrMonths);
        void Deposit(decimal amount);
    }
}
