using System.Net.Http;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Transactions
{
    public class TransactionsHttpClient : BasePlaidClient, ITransactions
    {
        public TransactionsHttpClient(HttpClient client) : base(client)
        {
        }

        public TransactionsGetResponse Get(TransactionsGetRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TransactionsGetResponse> GetAsync(TransactionsGetRequest request)
        {
            throw new System.NotImplementedException();
        }

        public BasePlaidResponse Refresh(TransactionsRefreshRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BasePlaidResponse> RefreshAsync(TransactionsRefreshRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}