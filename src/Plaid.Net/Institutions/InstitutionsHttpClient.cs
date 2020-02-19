using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Institutions
{
    public class InstitutionsHttpClient : BasePlaidClient, IInstitutions
    {
        public InstitutionsHttpClient(HttpClient client) : base(client)
        {
        }

        public InstitutionsGetResponse Get(InstitutionsGetRequest request)
        {
            return GetAsync(request).GetAwaiter().GetResult();
        }

        public async Task<InstitutionsGetResponse> GetAsync(InstitutionsGetRequest request)
        {
            throw new System.NotImplementedException();
        }

        public InstitutionsGetByIdResponse GetById(InstitutionsGetByIdRequest request)
        {
            return GetByIdAsync(request).GetAwaiter().GetResult();
        }

        public async Task<InstitutionsGetByIdResponse> GetByIdAsync(InstitutionsGetByIdRequest request)
        {
            throw new System.NotImplementedException();
        }

        public InstitutionsSearchResponse Search(InstitutionsSearchRequest request)
        {
            return SearchAsync(request).GetAwaiter().GetResult();
        }

        public async Task<InstitutionsSearchResponse> SearchAsync(InstitutionsSearchRequest request)
        {
            var data = JsonSerializer.Serialize(request, SerializerOptions);
            var content = new StringContent(data, Encoding.UTF8,"application/json");

            var httpResponse = await HttpClient.PostAsync("/institutions/search", content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<InstitutionsSearchResponse>(rawResponse, SerializerOptions);
        }
    }
}