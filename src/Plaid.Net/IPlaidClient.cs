using Plaid.Net.Accounts;
using Plaid.Net.Transactions;

namespace Plaid.Net
{
    public interface IPlaidClient
    {
        IAccounts Accounts { get; }

        ITransactions Transactions { get; }
    }
}