namespace Plaid.Net.Accounts
{
    public interface IAccounts
    {
        AccountBalanceGetResponse GetBalance();
        
        AccountBalanceGetResponse GetBalance(AccountBalanceGetOptions options);
    }
}