using Plaid.Net.Income;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class IncomeHttpClientTests : BaseItemITest
    {
        protected override string InstitutionId => TestData.Institution4;
        protected override string Product => "income";

        [Fact(Skip = "Flaky, need to figure out why")]
        public void Get()
        {
            var client = Client.Income;
            var actual = client.Get(new IncomeGetRequest
            {
                AccessToken = AccessToken,
                ClientId = ClientId,
                Secret = Secret
            });

            AssertResponse(actual);
            Assert.NotNull(actual.Income);
            Assert.NotEmpty(actual.Income.IncomeStreams);
        }
    }
}