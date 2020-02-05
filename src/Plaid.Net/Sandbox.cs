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
            return TokenCreateAsync(request).GetAwaiter().GetResult();
        }

        public async Task<SandboxTokenCreateResponse> TokenCreateAsync(SandboxTokenCreateRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data);

            var httpResponse = await HttpClient.PostAsync("/sandbox/public_token/create", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<SandboxTokenCreateResponse>(rawResponse, SerializerOptions);
        }

        public SandboxItemResetLoginResponse ItemResetLogin(SandboxItemResetLoginRequest request)
        {
            return ItemResetLoginAsync(request).GetAwaiter().GetResult();
        }

        public async Task<SandboxItemResetLoginResponse> ItemResetLoginAsync(SandboxItemResetLoginRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data);

            var httpResponse = await HttpClient.PostAsync("/sandbox/item/reset_login", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<SandboxItemResetLoginResponse>(rawResponse, SerializerOptions);
        }

        public SandboxItemFireWebhookResponse ItemFireWebhook(SandboxItemFireWebhookRequest request)
        {
            return ItemFireWebhookAsync(request).GetAwaiter().GetResult();
        }

        public async Task<SandboxItemFireWebhookResponse> ItemFireWebhookAsync(SandboxItemFireWebhookRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data);

            var httpResponse = await HttpClient.PostAsync("/sandbox/item/fire_webhook", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<SandboxItemFireWebhookResponse>(rawResponse, SerializerOptions);
        }
    }
}