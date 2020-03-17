namespace Plaid.Net.Identity
{
    public class IdentityGetRequest
    {
        public string AccessToken { get; set; }
        
        public string ClientId { get; set; }

        public string Secret { get; set; }
    }
}