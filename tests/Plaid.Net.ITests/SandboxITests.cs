using System.Threading.Tasks;
using Xunit;

namespace Plaid.Net.ITests
{
    public class SandboxITests : BaseITest
    {
        public SandboxITests(ITestFixture iTestFixture) : base(iTestFixture)
        {
        }
        
        [Fact]
        public async Task CreateToken()
        {
            var resp = await Client().Sandbox.TokenCreateAsync(new SandboxTokenCreateRequest
            {
                PublicKey = "ef380348545981f59c57944ccd40b4",
                InstitutionId = "ins_3",
                InitialProducts = new [] { "auth" }
            });
            
            Assert.NotNull(resp);
            Assert.NotNull(resp.PublicToken);
            Assert.NotNull(resp.RequestId);
        }
    }
}