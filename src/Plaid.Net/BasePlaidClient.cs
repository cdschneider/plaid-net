using System.Net.Http;
using System.Text.Json;
using Plaid.Net.Serialization;

namespace Plaid.Net
{
    public class BasePlaidClient
    {
        protected readonly HttpClient HttpClient;
        protected readonly JsonSerializerOptions SerializerOptions;

        public BasePlaidClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "Plaid .NET Client");

            HttpClient = client;
            SerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = (JsonNamingPolicy) new JsonSnakeCaseNamingPolicy(), 
                IgnoreNullValues = true
            };
        }
    }
}