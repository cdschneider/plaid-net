using System.Threading.Tasks;
using Plaid.Net.Institutions;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class InstitutionsHttpClientTests : BaseITest
    {
        [Fact]
        public async Task GetAsync()
        {
            var client = Client.Institutions;
            var resp = await client.GetAsync(new InstitutionsGetRequest
            {
                ClientId = ClientId,
                Secret = Secret,
                Count = 10
            });
            
            AssertResponse(resp);
            Assert.NotEmpty(resp.Institutions);
            Assert.Equal(10, resp.Institutions.Length);
            Assert.NotEqual(0, resp.Total);
        }
        
        [Fact]
        public async Task GetByIdAsync()
        {
            var client = Client.Institutions;
            var resp = await client.GetByIdAsync(new InstitutionsGetByIdRequest
            {
                PublicKey = PublicKey,
                InstitutionId = "ins_4"
            });
            
            AssertResponse(resp);
            Assert.NotNull(resp.Institution);
            Assert.Equal("Wells Fargo", resp.Institution.Name);
        }
        
        [Fact]
        public async Task SearchInstitutionsAsync()
        {
            var client = Client.Institutions;
            var resp = await client.SearchAsync(new InstitutionsSearchRequest
            {
                PublicKey = PublicKey,
                Products = new [] { "transactions" },
                Query = "bank", 
            });
            
            AssertResponse(resp);
            Assert.NotEmpty(resp.Institutions);
        }
    }
}