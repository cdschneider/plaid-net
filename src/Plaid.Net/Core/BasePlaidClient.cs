using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Plaid.Net.Serialization;

namespace Plaid.Net.Core
{
    public class BasePlaidClient
    {
        protected readonly HttpClient HttpClient;
        protected readonly JsonSerializerOptions SerializerOptions;

        public BasePlaidClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpClient = client;
            SerializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy(), IgnoreNullValues = true };
            SerializerOptions.Converters.Add(new PlaidDateTimeConverter());
        }
    }
}