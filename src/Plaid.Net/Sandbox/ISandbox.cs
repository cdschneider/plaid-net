using System.Threading.Tasks;

namespace Plaid.Net.Sandbox
{
    public interface ISandbox
    {
        SandboxTokenCreateResponse TokenCreate(SandboxTokenCreateRequest request);
        Task<SandboxTokenCreateResponse> TokenCreateAsync(SandboxTokenCreateRequest request);
        SandboxItemResetLoginResponse ItemResetLogin(SandboxItemResetLoginRequest request);
        Task<SandboxItemResetLoginResponse> ItemResetLoginAsync(SandboxItemResetLoginRequest request);
        SandboxItemFireWebhookResponse ItemFireWebhook(SandboxItemFireWebhookRequest request);
        Task<SandboxItemFireWebhookResponse> ItemFireWebhookAsync(SandboxItemFireWebhookRequest request);

    }
}