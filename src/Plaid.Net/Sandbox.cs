using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Plaid.Net
{
    public class Sandbox : BasePlaidClient, ISandbox
    {
        public Sandbox(HttpClient httpClient) : base(httpClient)
        {
        }

        public SandboxTokenCreateResponse TokenCreate(SandboxTokenCreateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SandboxTokenCreateResponse> TokenCreateAsync(SandboxTokenCreateRequest request)
        {
            var data = JsonSerializer.Serialize(request);
            var content = new StringContent(data);

            var httpResponse = await HttpClient.PostAsync("/sandbox/public_token/create", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<SandboxTokenCreateResponse>(rawResponse);
        }
    }
}