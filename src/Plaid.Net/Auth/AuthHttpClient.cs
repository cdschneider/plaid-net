using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Auth
{
    public class AuthHttpClient : BasePlaidClient, IAuth
    {
        public AuthHttpClient(HttpClient client) : base(client)
        {
        }

        public AuthGetResponse Get(AuthGetRequest request)
        {
            return GetAsync(request).GetAwaiter().GetResult();
        }

        public async Task<AuthGetResponse> GetAsync(AuthGetRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            var httpResponse = await HttpClient.PostAsync("/auth/get", content);
            httpResponse.EnsureSuccessStatusCode();
            
            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<AuthGetResponse>(rawResponse, SerializerOptions);
        }
    }
}