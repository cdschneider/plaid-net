using System.Threading.Tasks;
using Plaid.Net.Sandbox;
using Xunit;

namespace Plaid.Net.ITests
{
    public class SandboxHttpClientTests : BaseITest
    {
        public SandboxHttpClientTests(ITestFixture fixture) : base(fixture)
        {
        }
        
        [Fact]
        public async Task CreateToken()
        {
            var client = Client().Sandbox;
            var resp = await client.TokenCreateAsync(new SandboxTokenCreateRequest
            {
                PublicKey = "ef380348545981f59c57944ccd40b4",
                InstitutionId = TestData.Institution1,
                InitialProducts = new [] { "auth" }
            });
            
            Assert.NotNull(resp);
            Assert.NotNull(resp.PublicToken);
            Assert.NotNull(resp.RequestId);
        }
    }
}