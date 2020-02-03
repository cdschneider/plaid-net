using System.Net.Http;

namespace Plaid.Net
{
    public class BasePlaidClient
    {
        protected readonly HttpClient HttpClient;

        public BasePlaidClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "Plaid .NET Client");

            HttpClient = client;
        }
    }
}