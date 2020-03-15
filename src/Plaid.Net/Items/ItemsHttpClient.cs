using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Plaid.Net.Accounts;
using Plaid.Net.Core;

namespace Plaid.Net.Items
{
    public class ItemsHttpClient : BasePlaidClient, IItems
    {
        public ItemsHttpClient(HttpClient client) : base(client)
        {
        }

        public ItemGetResponse Get(ItemGetRequest request)
        {
            return GetAsync(request).GetAwaiter().GetResult();
        }

        public async Task<ItemGetResponse> GetAsync(ItemGetRequest request)
        {
            throw new System.NotImplementedException();
        }

        public PublicTokenCreateResponse PublicTokenCreate(PublicTokenCreateRequest request)
        {
            return PublicTokenCreateAsync(request).GetAwaiter().GetResult();
        }

        public async Task<PublicTokenCreateResponse> PublicTokenCreateAsync(PublicTokenCreateRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/item/public_token/create", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PublicTokenCreateResponse>(rawResponse, SerializerOptions);
        }

        public PublicTokenExchangeResponse PublicTokenExchange(PublicTokenExchangeRequest request)
        {
            return PublicTokenExchangeAsync(request).GetAwaiter().GetResult();
        }

        public async Task<PublicTokenExchangeResponse> PublicTokenExchangeAsync(PublicTokenExchangeRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/item/public_token/exchange", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PublicTokenExchangeResponse>(rawResponse, SerializerOptions);
        }
    }
}