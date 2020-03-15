using System.Threading.Tasks;
using Plaid.Net.ITests.Core;
using Plaid.Net.Transactions;
using Xunit;

namespace Plaid.Net.ITests
{
    public class TransactionsHttpClientTests : BaseItemITest
    {
        protected override string InstitutionId => TestData.Institution1;
        protected override string Product => "transactions";
        
        [Fact]
        public async Task GetAsync()
        {
            var client = Client.Transactions;
            var resp = await client.GetAsync(new TransactionsGetRequest
            {
                AccessToken = AccessToken,
                ClientId = ClientId,
                Secret = Secret
            });
            
            AssertItem(resp);
        }
    }
}