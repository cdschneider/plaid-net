using Plaid.Net.Auth;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class AuthHttpClientTests : BaseItemITest
    {
        protected override string InstitutionId => TestData.Institution1;
        protected override string Product => "auth";

        [Fact]
        public void Get()
        {
            var client = Client.Auth;
            var actual = client.Get(new AuthGetRequest
            {
                AccessToken = AccessToken,
                ClientId = ClientId,
                Secret = Secret
            });
            
            AssertItem(actual);
        }
    }
}