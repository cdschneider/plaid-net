using System.Threading.Tasks;
using Plaid.Net.ITests.Core;
using Plaid.Net.Sandbox;
using Xunit;

namespace Plaid.Net.ITests
{
    public class SandboxHttpClientTests : BaseITest
    {   
        [Fact]
        public async Task CreateToken()
        {
            var client = Client.Sandbox;
            var resp = await client.TokenCreateAsync(new SandboxTokenCreateRequest
            {
                PublicKey = PublicKey,
                InstitutionId = TestData.Institution1,
                InitialProducts = new [] { "auth" }
            });
            
            AssertResponse(resp);
            Assert.NotNull(resp.PublicToken);
        }
    }
}