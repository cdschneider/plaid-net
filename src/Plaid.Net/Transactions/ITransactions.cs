using System;

namespace Plaid.Net.Transactions
{
    public interface ITransactions
    {
        TransactionsGetResponse Get(DateTime startDate, DateTime endDate);

        TransactionsGetResponse Get(DateTime startDate, DateTime endDate, TransactionsGetOptions options);
    }
}