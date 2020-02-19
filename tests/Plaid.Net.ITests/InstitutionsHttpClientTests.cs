using System.Threading.Tasks;
using Plaid.Net.Institutions;
using Xunit;

namespace Plaid.Net.ITests
{
    public class InstitutionsHttpClientTests : BaseITest
    {
        public InstitutionsHttpClientTests(ITestFixture fixture) : base(fixture)
        {
        }
        
        [Fact]
        public async Task SearchInstitutions()
        {
            var client = Client().Institutions;
            var resp = await client.SearchAsync(new InstitutionsSearchRequest
            {
                PublicKey = "ef380348545981f59c57944ccd40b4",
                Query = "bank",
                Products = new [] { "transactions" }
            });
            
            Assert.NotNull(resp);
            Assert.NotNull(resp.RequestId);
            Assert.NotEmpty(resp.Institutions);
        }

        [Fact]
        public async Task GetById()
        {
            var client = Client().Institutions;
            var resp = await client.GetByIdAsync(new InstitutionsGetByIdRequest
            {
                PublicKey = "ef380348545981f59c57944ccd40b4",
                InstitutionId = "ins_4"
            });
            
            Assert.NotNull(resp);
            Assert.NotNull(resp.RequestId);
            Assert.NotNull(resp.Institution);
            Assert.Equal("Wells Fargo", resp.Institution.Name);
        }

        [Fact]
        public async Task Get()
        {
            var client = Client().Institutions;
            var resp = await client.GetAsync(new InstitutionsGetRequest
            {
                ClientId = "5e1db5008fc32f0012966dc4",
                Secret = "2c9fab93287d4c222f700c3cf17c95",
                Count = 10
            });
            
            Assert.NotNull(resp);
            Assert.NotNull(resp.RequestId);
            Assert.NotEmpty(resp.Institutions);
            Assert.Equal(10, resp.Institutions.Length);
            Assert.NotEqual(0, resp.Total);
        }
    }
}