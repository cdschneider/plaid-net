using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Accounts
{
    public class AccountsHttpClient : BasePlaidClient, IAccounts
    {
        public AccountsHttpClient(HttpClient client) : base(client)
        {
        }

        public AccountGetResponse Get(AccountGetRequest request)
        {
            return GetAsync(request).GetAwaiter().GetResult();
        }

        public async Task<AccountGetResponse> GetAsync(AccountGetRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/accounts/get", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<AccountGetResponse>(rawResponse, SerializerOptions);
        }

        public AccountBalancesGetResponse GetBalance(AccountBalancesGetRequest request)
        {
            return GetBalanceAsync(request).GetAwaiter().GetResult();
        }

        public async Task<AccountBalancesGetResponse> GetBalanceAsync(AccountBalancesGetRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/accounts/balance/get", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<AccountBalancesGetResponse>(rawResponse, SerializerOptions);
        }
    }
}