namespace Plaid.Net.Income
{
    public class IncomeGetRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string AccessToken { get; set; }
    }
}