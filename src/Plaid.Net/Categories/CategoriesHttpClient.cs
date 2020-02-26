using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Categories
{
    public class CategoriesHttpClient : BasePlaidClient, ICategories
    {
        public CategoriesHttpClient(HttpClient client) : base(client)
        {
        }

        public CategoriesGetResponse Get()
        {
            return GetAsync().GetAwaiter().GetResult();
        }
        
        public async Task<CategoriesGetResponse> GetAsync()
        {
            var data = JsonSerializer.Serialize(new {}, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/categories/get", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CategoriesGetResponse>(rawResponse, SerializerOptions);
        }
    }
}