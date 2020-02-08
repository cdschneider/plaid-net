using System.Net.Http;

namespace Plaid.Net
{
    public sealed class PlaidClient : IPlaidClient
    {
        public PlaidClient(IHttpClientFactory httpClientFactory)
        {
            var httpClient = httpClientFactory.CreateClient("plaid");
            
            Sandbox = new Sandbox(httpClient);
        }
        
        public ISandbox Sandbox { get; }
    }
}