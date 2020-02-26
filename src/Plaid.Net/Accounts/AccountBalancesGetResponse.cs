namespace Plaid.Net.Accounts
{
    public class AccountBalancesGetResponse
    {
        public AccountResponse[] Accounts { get; set; }
        
        public object Item { get; set; }
    }
}