namespace Plaid.Net.Items
{
    public class PublicTokenExchangeRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string PublicToken { get; set; }
    }
}