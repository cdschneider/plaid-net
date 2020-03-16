using Plaid.Net.Accounts;
using Plaid.Net.Core;

namespace Plaid.Net.Transactions
{
    public class TransactionsGetResponse : BasePlaidItemResponse
    {
        public AccountResponse[] Accounts { get; set; }
        
        public TransactionResponse[] Transactions { get; set; }
        
        public long TotalTransactions { get; set; }
    }
}