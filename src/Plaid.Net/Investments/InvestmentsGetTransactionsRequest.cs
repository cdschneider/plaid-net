using System;

namespace Plaid.Net.Investments
{
    public class InvestmentsGetTransactionsRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string AccessToken { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        
        public InvestmentsGetTransactionsRequestOptions Options { get; set; }
    }

    public class InvestmentsGetTransactionsRequestOptions
    {
        public string[] AccountIds { get; set; }
        
        public int Count { get; set; }
        
        public int Offset { get; set; }
    }
}