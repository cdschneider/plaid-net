namespace Plaid.Net.Accounts
{
    public class AccountGetRequest
    {
        public string ClientId { get; set; }

        public string Secret { get; set; }

        public string AccessKey { get; set; }
    }
}