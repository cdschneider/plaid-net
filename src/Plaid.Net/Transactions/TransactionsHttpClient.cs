using System.Net.Http;
using System.Text;
using System.Text.Json;
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
            return GetAsync(request).GetAwaiter().GetResult();
        }

        public async Task<TransactionsGetResponse> GetAsync(TransactionsGetRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/transactions/get", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TransactionsGetResponse>(rawResponse, SerializerOptions);
        }

        public BasePlaidResponse Refresh(TransactionsRefreshRequest request)
        {
            return RefreshAsync(request).GetAwaiter().GetResult();
        }

        public async Task<BasePlaidResponse> RefreshAsync(TransactionsRefreshRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/transactions/refresh", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BasePlaidResponse>(rawResponse, SerializerOptions);
        }
    }
}