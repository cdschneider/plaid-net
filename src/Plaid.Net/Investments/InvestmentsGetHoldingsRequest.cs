namespace Plaid.Net.Investments
{
    public class InvestmentsGetHoldingsRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string AccessToken { get; set; }
        
        public InvestmentsGetHoldingsRequestOptions Options { get; set; }
    }

    public class InvestmentsGetHoldingsRequestOptions
    {
        public string[] AccountIds { get; set; }
    }
}