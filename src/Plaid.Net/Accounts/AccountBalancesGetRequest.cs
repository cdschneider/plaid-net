namespace Plaid.Net.Accounts
{
    public class AccountBalancesGetRequest : AccountGetRequest
    {
        public AccountBalancesGetRequestOptions Options { get; set; }
    }

    public class AccountBalancesGetRequestOptions
    {
        public string[] AccountIds { get; set; }
    }
}