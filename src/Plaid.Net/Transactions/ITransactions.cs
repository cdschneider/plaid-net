using System.Threading.Tasks;

namespace Plaid.Net.Transactions
{
    public interface ITransactions
    {
        TransactionsGetResponse Get(TransactionsGetRequest request);
        Task<TransactionsGetResponse> GetAsync(TransactionsGetRequest request);
    }
}