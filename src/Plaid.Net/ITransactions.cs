using System;
using Plaid.Net.Transactions;

namespace Plaid.Net
{
    public interface ITransactions
    {
        TransactionsGetResponse Get(DateTime startDate, DateTime endDate);

        TransactionsGetResponse Get(DateTime startDate, DateTime endDate, TransactionsGetOptions options);
    }
}