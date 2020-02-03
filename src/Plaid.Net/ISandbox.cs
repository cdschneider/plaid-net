using System.Threading.Tasks;

namespace Plaid.Net
{
    public interface ISandbox
    {
        SandboxTokenCreateResponse TokenCreate(SandboxTokenCreateRequest request);
        Task<SandboxTokenCreateResponse> TokenCreateAsync(SandboxTokenCreateRequest request);
    }
}