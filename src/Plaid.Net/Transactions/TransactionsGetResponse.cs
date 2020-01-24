using System.Collections.Generic;

namespace Plaid.Net.Transactions
{
    public class TransactionsGetResponse
    {
        public object[] Accounts; //TODO

        public List<TransactionResponse> Transactions;

        public object Item; //TODO

        public int TotalTransactions;

        public string RequestId;
    }
}