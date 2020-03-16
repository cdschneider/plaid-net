using System.Threading.Tasks;
using Plaid.Net.Accounts;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class AccountsHttpClientTests : BaseItemITest
    {
        protected override string InstitutionId => TestData.Institution1;
        protected override string Product => "transactions";

        [Fact]
        public void Get()
        {
            var client = Client.Accounts;
            var actual = client.Get(new AccountGetRequest 
                { AccessToken = AccessToken, ClientId = ClientId, Secret = Secret });
            
            AssertItem(actual);
        }
    }
}