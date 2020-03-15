using System;

namespace Plaid.Net.Transactions
{
    public class TransactionsStatusResponse
    {
        public DateTime? LastSuccessfulUpdate { get; set; }
        
        public DateTime? LastFailedUpdate { get; set; }
    }
}