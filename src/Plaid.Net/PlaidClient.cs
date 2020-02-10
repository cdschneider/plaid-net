using System.Net.Http;
using Plaid.Net.Sandbox;

namespace Plaid.Net
{
    public sealed class PlaidClient : IPlaidClient
    {
        public PlaidClient(IHttpClientFactory httpClientFactory)
        {
            var httpClient = httpClientFactory.CreateClient("plaid");
            Sandbox = new SandboxHttpClient(httpClient);
        }
        
        public ISandbox Sandbox { get; }
    }
}