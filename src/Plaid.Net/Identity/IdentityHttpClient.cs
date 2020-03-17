using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Identity
{
    public class IdentityHttpClient : BasePlaidClient, IIdentity
    {
        public IdentityHttpClient(HttpClient client) : base(client)
        {
        }

        public IdentityGetResponse Get(IdentityGetRequest request)
        {
            return GetAsync(request).GetAwaiter().GetResult();
        }

        public async Task<IdentityGetResponse> GetAsync(IdentityGetRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/identity/get", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IdentityGetResponse>(rawResponse, SerializerOptions);
        }
    }
}