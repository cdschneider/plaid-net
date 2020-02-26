using System.Net.Http;
using Plaid.Net.Categories;
using Plaid.Net.Institutions;
using Plaid.Net.Sandbox;

namespace Plaid.Net
{
    public sealed class PlaidClient : IPlaidClient
    {
        public PlaidClient(IHttpClientFactory httpClientFactory)
        {
            var httpClient = httpClientFactory.CreateClient("plaid");
            
            Sandbox = new SandboxHttpClient(httpClient);
            Institutions = new InstitutionsHttpClient(httpClient);
            Categories = new CategoriesHttpClient(httpClient);
        }
        
        public ISandbox Sandbox { get; }
        
        public IInstitutions Institutions { get; }
        
        public ICategories Categories { get; }
    }
}