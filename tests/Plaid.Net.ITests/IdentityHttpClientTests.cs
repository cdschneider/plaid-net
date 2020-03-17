using Plaid.Net.Identity;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class IdentityHttpClientTests : BaseItemITest
    {
        protected override string InstitutionId => TestData.Institution1;
        protected override string Product => "identity";

        [Fact]
        public void Get()
        {
            var client = Client.Identity;
            var actual = client.Get(new IdentityGetRequest
            {
                AccessToken = AccessToken,
                ClientId = ClientId,
                Secret = Secret
            });
            
            AssertItem(actual);
        }
    }
}