namespace Plaid.Net.Accounts
{
    public class AccountBalancesGetRequest
    {
        public string ClientId { get; set; }

        public string Secret { get; set; }

        public string AccessKey { get; set; }
        
        public AccountBalancesGetRequestOptions Options { get; set; }
    }

    public class AccountBalancesGetRequestOptions
    {
        public string[] AccountIds { get; set; }
    }
}