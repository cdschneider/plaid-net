using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Transactions
{
    public interface ITransactions
    {
        TransactionsGetResponse Get(TransactionsGetRequest request);
        Task<TransactionsGetResponse> GetAsync(TransactionsGetRequest request);
        BasePlaidResponse Refresh(TransactionsRefreshRequest request);
        Task<BasePlaidResponse> RefreshAsync(TransactionsRefreshRequest request);
    }
}