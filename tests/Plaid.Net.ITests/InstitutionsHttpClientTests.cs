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
    }
}