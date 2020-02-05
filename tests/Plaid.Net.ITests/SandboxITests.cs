using System.Threading.Tasks;
using Xunit;

namespace Plaid.Net.ITests
{
    public class SandboxITests
    {
        [Fact]
        public async Task CreateToken()
        {
            var client = PlaidClient.Builder()
                .ApiEnvironment(PlaidApiEnvironment.Sandbox)
                .Build();
            
            var request = new SandboxTokenCreateRequest();
            var response = await client.Sandbox.TokenCreateAsync(request);
        }
    }
}