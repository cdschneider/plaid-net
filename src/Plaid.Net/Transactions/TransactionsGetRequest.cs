using System;

namespace Plaid.Net.Transactions
{
    public class TransactionsGetRequest
    {
        public string ClientId { get; set; }

        public string Secret { get; set; }

        public string AccessKey { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public dynamic Options { get; set; }
    }
    
    public class TransactionsGetOptions
    {
        public string[] AccountIds { get; set; }

        public int Count { get; set; }
        
        public int Offset { get; set; }
    }
}