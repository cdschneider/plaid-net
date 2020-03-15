namespace Plaid.Net.Items
{
    public class ItemGetRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string AccessToken { get; set; }
    }
}