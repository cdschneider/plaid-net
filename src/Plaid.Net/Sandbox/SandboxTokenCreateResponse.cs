using Plaid.Net.Core;

namespace Plaid.Net.Sandbox
{
    public class SandboxTokenCreateResponse : BasePlaidResponse
    {
        public string PublicToken { get; set; }
    }
}